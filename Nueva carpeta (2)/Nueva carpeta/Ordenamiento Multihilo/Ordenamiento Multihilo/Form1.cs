using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using System.Windows.Forms;
using System.Diagnostics;
using System.Linq;
using System.IO;
using Word = Microsoft.Office.Interop.Word;


namespace OrdenamientoMultihilo

   
{
   
    public partial class Form1 : Form
    {
        private List<int> listaOriginal;
        private List<int> listaBurbuja;
        private List<int> listaQuick;
        private List<int> listaMerge;
        private List<int> listaSelection;
        private Thread hiloBurbuja;
        private Thread hiloMerge;
        private Thread hiloSelection;
        private Stopwatch relojBurbuja = new Stopwatch();
        private Stopwatch relojQuick = new Stopwatch();
        private Stopwatch relojMerge = new Stopwatch();
        private Stopwatch relojSelection = new Stopwatch();
        private volatile bool cancelRequested = false;

        private void GuardarReporte(string algoritmo, List<int> original, List<int> ordenada, long tiempoMs)
        {

            var originalLim = original.Take(1000).ToList();
            var ordenadaLim = ordenada.Take(1000).ToList();

            int pasos = 5; // número de avances que se mostrarán
            List<List<int>> avances = new List<List<int>>();
            int salto = Math.Max(1, ordenadaLim.Count / pasos);

            for (int i = 1; i <= pasos; i++)
            {
                int limite = salto * i;
                var parcial = ordenada.Take(limite).Concat(original.Skip(limite).Take(1000 - limite)).ToList();
                avances.Add(parcial);
            }

            Word.Application wordApp = new Word.Application();
            wordApp.Visible = false;

            Word.Document doc = wordApp.Documents.Add();

            // Título
            Word.Paragraph title = doc.Content.Paragraphs.Add();
            title.Range.Text = $"Reporte de Ordenamiento - {algoritmo}";
            title.Range.Font.Bold = 1;
            title.Range.Font.Size = 18;
            title.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
            title.Range.InsertParagraphAfter();

            // Tiempo de ejecución
            Word.Paragraph timeP = doc.Content.Paragraphs.Add();
            timeP.Range.Text = $"Tiempo de ejecución: {tiempoMs} ms";
            timeP.Range.Font.Size = 12;
            timeP.Range.InsertParagraphAfter();

            // Inicio del proceso
            Word.Paragraph inicio = doc.Content.Paragraphs.Add();
            inicio.Range.Text = $"Inicio del proceso: {DateTime.Now}";
            inicio.Range.InsertParagraphAfter();

            // Lista original
            Word.Paragraph origP = doc.Content.Paragraphs.Add();
            origP.Range.Text = "\nLista Original (máximo 1000 elementos):";
            origP.Range.Font.Bold = 1;
            origP.Range.InsertParagraphAfter();

            Word.Range rangeOriginal = doc.Content.Paragraphs.Add().Range;
            rangeOriginal.InsertAfter(string.Join(", ", originalLim));
            rangeOriginal.InsertParagraphAfter();

            // Avance del proceso en 3 etapas
            Word.Paragraph avanceTitle = doc.Content.Paragraphs.Add();
            avanceTitle.Range.Text = "\nAvance del proceso de ordenamiento (simulación con 5 etapas):";
            avanceTitle.Range.Font.Bold = 1;
            avanceTitle.Range.InsertParagraphAfter();

            int etapa = 1;
            foreach (var paso in avances)
            {
                Word.Paragraph etapaP = doc.Content.Paragraphs.Add();
                etapaP.Range.Text = $"Etapa {etapa++}:";
                etapaP.Range.Font.Bold = 1;
                etapaP.Range.InsertParagraphAfter();

                Word.Range rangeEtapa = doc.Content.Paragraphs.Add().Range;
                rangeEtapa.InsertAfter(string.Join(", ", paso.Take(1000)));
                rangeEtapa.InsertParagraphAfter();
            }

            // Lista ordenada
            Word.Paragraph ordP = doc.Content.Paragraphs.Add();
            ordP.Range.Text = "\nLista Ordenada (máximo 1000 elementos):";
            ordP.Range.Font.Bold = 1;
            ordP.Range.InsertParagraphAfter();

            Word.Range rangeOrdenada = doc.Content.Paragraphs.Add().Range;
            rangeOrdenada.InsertAfter(string.Join(", ", ordenadaLim));
            rangeOrdenada.InsertParagraphAfter();

            // Fin del proceso
            Word.Paragraph fin = doc.Content.Paragraphs.Add();
            fin.Range.Text = $"\nFinalización del proceso: {DateTime.Now}";
            fin.Range.InsertParagraphAfter();

            string path = $"{algoritmo}_Reporte.docx";
            doc.SaveAs2(Path.Combine(Environment.CurrentDirectory, path));
            doc.Close();
            wordApp.Quit();

            MessageBox.Show($"Documento guardado: {Path.Combine(Environment.CurrentDirectory, path)}", "Reporte Generado");
        }

        
        

        public Form1()
        {
            InitializeComponent();
            chartTiempos.Series["Tiempos"].Points.Clear();
            chartTiempos.Series["Tiempos"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            chartTiempos.Series["Tiempos"].IsValueShownAsLabel= true;

           txtMerge.Text = "";
            txtSelection.Text = "";

           
            
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            int cantidad = 100000;
            if (!int.TryParse(txtCantidad.Text.Trim(), out cantidad) || cantidad <= 0)
                cantidad = 100000;

            Random rnd = new Random();
            listaOriginal = new List<int>(cantidad);
            for (int i = 0; i < cantidad; i++)
                listaOriginal.Add(rnd.Next(0, 1000000));

            UpdateGridSample();
            MessageBox.Show($"Lista generada correctamente con {cantidad} números.", "Generado");
        }

        private void UpdateGridSample()
        {
            if (listaOriginal == null) return;
            var sample = listaOriginal.Take(200).Select((v, i) => new { Index = i, Value = v }).ToList();
            dgvMuestra.Invoke(new Action(() => {
                dgvMuestra.DataSource = sample;
            }));
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (listaOriginal == null || listaOriginal.Count == 0)
            {
                MessageBox.Show("Primero genera los datos.");
                return;
            }

            listaBurbuja = new List<int>(listaOriginal);
            listaQuick = new List<int>(listaOriginal);

            cancelRequested = false;
            progressBurbuja.Value = 0;
            progressQuickSort.Value = 0;
            lblBurbuja.Text = "Burbuja: 0%";
            lblQuickSort.Text = "QuickSort: 0%";
            lblMergeSort.Text = "MergeSort: 0%";
            lblSelectionSort.Text = "Selection: 0%";
            chartTiempos.Series["Tiempos"].Points.Clear();
            txtBurbuja.Text = "";
            txtQuick.Text = "";
            txtMerge.Text = "";
            txtSelection.Text = "";

            btnIniciar.Enabled = false;
            btnGenerar.Enabled = false;
            btnDetener.Enabled = true;

            hiloBurbuja = new Thread(new ThreadStart(OrdenarBurbuja));
            hiloBurbuja.IsBackground = true;
            hiloBurbuja.Start();

            listaMerge = new List<int>(listaOriginal);
            listaSelection = new List<int>(listaOriginal);

            hiloMerge = new Thread(new ThreadStart(MergeSort));
            hiloMerge.IsBackground = true;
            hiloMerge.Start();

            hiloSelection = new Thread(new ThreadStart(SelectionSort));
            hiloSelection.IsBackground = true;
            hiloSelection.Start();

            backgroundWorkerQuickSort.RunWorkerAsync(listaQuick);
            btnNuevoProceso.Enabled = true;
        }

        private void OrdenarBurbuja()
        {
            relojBurbuja.Restart();
            int n = listaBurbuja.Count;
            for (int i = 0; i < n - 1; i++)
            {
                if (cancelRequested) break;
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (cancelRequested) break;
                    if (listaBurbuja[j] > listaBurbuja[j + 1])
                    {
                        int temp = listaBurbuja[j];
                        listaBurbuja[j] = listaBurbuja[j + 1];
                        listaBurbuja[j + 1] = temp;
                    }
                }

                if (i % Math.Max(1, n/100) == 0)
                {
                    int progreso = (int)((i / (float)n) * 100);
                    this.Invoke(new Action(() =>
                    {
                        progressBurbuja.Value = Math.Min(Math.Max(progreso, 0), 100);
                        lblBurbuja.Text = $"Burbuja: {progreso}%";
                    }));
                }
            }

            relojBurbuja.Stop();
            this.Invoke(new Action(() =>
            {
                if (!cancelRequested)
                {
                    progressBurbuja.Value = 100;
                    lblBurbuja.Text = $"Burbuja: Completado en {relojBurbuja.ElapsedMilliseconds} ms";
                    txtBurbuja.Text = $"{relojBurbuja.ElapsedMilliseconds} ms";
                    chartTiempos.Series["Tiempos"].Points.AddXY("Burbuja", relojBurbuja.ElapsedMilliseconds);
                }
                else
                {
                    lblBurbuja.Text = $"Burbuja: Detenido a {relojBurbuja.ElapsedMilliseconds} ms";
                    txtBurbuja.Text = $"Detenido ({relojBurbuja.ElapsedMilliseconds} ms)";
                }
                GuardarReporte("Burbuja", listaOriginal, listaBurbuja, relojBurbuja.ElapsedMilliseconds);
                CheckFinishState();
                UpdateGridAfter();
               


            }));
            

        }



        private void SelectionSort()
        {
            relojSelection.Restart();
            int n = listaSelection.Count;
            for (int i = 0; i < n - 1; i++)
            {
                if (cancelRequested) break;
                int minIdx = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (listaSelection[j] < listaSelection[minIdx]) minIdx = j;
                }
                if (minIdx != i)
                {
                    int tmp = listaSelection[i];
                    listaSelection[i] = listaSelection[minIdx];
                    listaSelection[minIdx] = tmp;
                }

                if (i % Math.Max(1, n/100) == 0)
                {
                    int progreso = (int)((i / (float)n) * 100);
                    this.Invoke(new Action(() =>
                    {
                        progressSelection.Value = Math.Min(Math.Max(progreso, 0), 100);
                        txtSelection.Text = $"{progreso}%";
                    }));
                }
            }

            relojSelection.Stop();
            this.Invoke(new Action(() =>
            {
                if (!cancelRequested)
                {
                    progressSelection.Value = 100;
                    lblSelectionSort.Text = $"Selection: Completado en {relojSelection.ElapsedMilliseconds} ms";
                    txtSelection.Text = $"{relojSelection.ElapsedMilliseconds} ms";
                    chartTiempos.Series["Tiempos"].Points.AddXY("SelectionSort", relojSelection.ElapsedMilliseconds);
                }
                else
                {
                    lblSelectionSort.Text = $"Selection: Detenido a {relojSelection.ElapsedMilliseconds} ms";
                    txtSelection.Text = $"Detenido ({relojSelection.ElapsedMilliseconds} ms)";
                }
                GuardarReporte("SelectionSort", listaOriginal, listaSelection, relojSelection.ElapsedMilliseconds);
                CheckFinishState();
            }));
        }

        private void MergeSort()
        {
            relojMerge.Restart();
            List<int> aux = new List<int>(listaMerge);
            MergeSortRec(listaMerge, aux, 0, listaMerge.Count - 1);
            relojMerge.Stop();
            this.Invoke(new Action(() =>
            {
                if (!cancelRequested)
                {
                    progressMerge.Value = 100;
                    lblMergeSort.Text = $"Merge: Completado en {relojMerge.ElapsedMilliseconds} ms";
                    txtMerge.Text = $"{relojMerge.ElapsedMilliseconds} ms";
                    chartTiempos.Series["Tiempos"].Points.AddXY("MergeSort", relojMerge.ElapsedMilliseconds);
                }
                else
                {

                    lblMergeSort.Text = $"Merge: Detenido a {relojMerge.ElapsedMilliseconds} ms";
                    txtMerge.Text = $"Detenido ({relojMerge.ElapsedMilliseconds} ms)";
                }
                GuardarReporte("MergeSort", listaOriginal, listaMerge, relojMerge.ElapsedMilliseconds);
                CheckFinishState();
            }));
        }

        private void MergeSortRec(List<int> arr, List<int> aux, int left, int right)
        {
            if (cancelRequested) return;
            if (left >= right) return;
            int mid = (left + right) / 2;
            MergeSortRec(arr, aux, left, mid);
            MergeSortRec(arr, aux, mid + 1, right);
            Merge(arr, aux, left, mid, right);
        }

        private void Merge(List<int> arr, List<int> aux, int left, int mid, int right)
        {
            int i = left, j = mid + 1, k = left;
            while (i <= mid && j <= right)
            {
                if (arr[i] <= arr[j])
                {
                    aux[k++] = arr[i++];
                }
                else
                {
                    aux[k++] = arr[j++];
                }
            }
            while (i <= mid) aux[k++] = arr[i++];
            while (j <= right) aux[k++] = arr[j++];

            for (int p = left; p <= right; p++)
                arr[p] = aux[p];

            
            int progreso = (int)((right / (float)listaMerge.Count) * 100);
            this.Invoke(new Action(() =>
            {
                progressMerge.Value = Math.Min(Math.Max(progreso, 0), 100);
                txtMerge.Text = $"{progreso}%";
            }));
        }

        private void UpdateGridAfter()
        {
            var sample = listaBurbuja?.Take(200).Select((v, i) => new { Index = i, Value = v }).ToList();
            if (sample != null)
            {
                dgvMuestra.Invoke(new Action(() => {
                    dgvMuestra.DataSource = sample;
                }));
            }
        }

        private void QuickSort(List<int> lista, int izquierda, int derecha, BackgroundWorker worker)
        {
            if (worker.CancellationPending || cancelRequested) return;

            if (izquierda < derecha)
            {
                int pivot = Particionar(lista, izquierda, derecha, worker);
                QuickSort(lista, izquierda, pivot - 1, worker);
                QuickSort(lista, pivot + 1, derecha, worker);
            }

            if (derecha % Math.Max(1, lista.Count/100) == 0)
            {
                int progreso = (int)((derecha / (float)lista.Count) * 100);
                worker.ReportProgress(Math.Min(Math.Max(progreso, 0), 100));
            }
        }

        private int Particionar(List<int> lista, int izquierda, int derecha, BackgroundWorker worker)
        {
            if (worker.CancellationPending || cancelRequested) return izquierda;
            int pivote = lista[derecha];
            int i = izquierda - 1;
            for (int j = izquierda; j < derecha; j++)
            {
                if (worker.CancellationPending || cancelRequested) break;
                if (lista[j] <= pivote)
                {
                    i++;
                    int temp = lista[i];
                    lista[i] = lista[j];
                    lista[j] = temp;
                }
            }
            int temp2 = lista[i + 1];
            lista[i + 1] = lista[derecha];
            lista[derecha] = temp2;
            return i + 1;
        }

        private void backgroundWorkerQuickSort_DoWork(object sender, DoWorkEventArgs e)
        {
            relojQuick.Restart();
            List<int> lista = (List<int>)e.Argument;
            QuickSort(lista, 0, lista.Count - 1, backgroundWorkerQuickSort);
            e.Result = lista;
        }

        private void backgroundWorkerQuickSort_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressQuickSort.Value = e.ProgressPercentage;
            lblQuickSort.Text = $"QuickSort: {e.ProgressPercentage}%";
        }

        private void backgroundWorkerQuickSort_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            relojQuick.Stop();
            if (!e.Cancelled && !cancelRequested)
            {
                lblQuickSort.Text = $"QuickSort: Completado en {relojQuick.ElapsedMilliseconds} ms";
                progressQuickSort.Value = 100;
                txtQuick.Text = $"{relojQuick.ElapsedMilliseconds} ms";
                chartTiempos.Series["Tiempos"].Points.AddXY("QuickSort", relojQuick.ElapsedMilliseconds);
                var sorted = e.Result as List<int>;
                dgvMuestra.DataSource = sorted?.Take(200).Select((v, i) => new { Index = i, Value = v }).ToList();
            }
            else
            {
                lblQuickSort.Text = $"QuickSort: Detenido a {relojQuick.ElapsedMilliseconds} ms";
                txtQuick.Text = $"Detenido ({relojQuick.ElapsedMilliseconds} ms)";
               
            }
            GuardarReporte("QuickSort", listaOriginal, listaQuick, relojQuick.ElapsedMilliseconds);
            CheckFinishState();
        }

        private void btnDetener_Click(object sender, EventArgs e)
        {
            btnDetener.Enabled = false;
            btnNuevoProceso.Enabled = true;
            cancelRequested = true;
            if (backgroundWorkerQuickSort.WorkerSupportsCancellation)
                backgroundWorkerQuickSort.CancelAsync();

            if (hiloBurbuja != null && hiloBurbuja.IsAlive)
                hiloBurbuja.Join(500);
            if (hiloMerge != null && hiloMerge.IsAlive)
                hiloMerge.Join(500);
            if (hiloSelection != null && hiloSelection.IsAlive)
                hiloSelection.Join(500);
        }

        

        private void CheckFinishState()
        {
            bool quickDone = !backgroundWorkerQuickSort.IsBusy;
            bool burbujaDone = (hiloBurbuja == null) || !hiloBurbuja.IsAlive;
            bool mergeDone = (hiloMerge == null) || !hiloMerge.IsAlive;
            bool selectionDone = (hiloSelection == null) || !hiloSelection.IsAlive;
            if (quickDone && burbujaDone && mergeDone && selectionDone)
            {
                btnIniciar.Enabled = true;
                btnGenerar.Enabled = true;
                btnDetener.Enabled = false;
                
            }
            
        }

       
        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void progressBurbuja_Click(object sender, EventArgs e)
        {

        }

        private void lblBurbuja_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ignora el carácter ingresado.
            }
        }

        private void btnNuevoProceso_Click(object sender, EventArgs e)
        {
            listaOriginal.Clear();
            listaBurbuja.Clear();
            listaMerge.Clear();
            listaQuick.Clear();
            listaSelection.Clear();
            UpdateGridSample();
            btnGenerar.Enabled = true;
            btnIniciar.Enabled = true;
            btnDetener.Enabled = true;
            txtBurbuja.Text= string.Empty;
            txtCantidad.Text= string.Empty;
            txtMerge.Text= string.Empty;
            txtSelection.Text= string.Empty;
            txtQuick.Text= string.Empty;
            chartTiempos.Series["Tiempos"].Points.Clear();
            chartTiempos.Series["Tiempos"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            chartTiempos.Series["Tiempos"].IsValueShownAsLabel = true;
            progressBurbuja.Value = 0;
            progressQuickSort.Value = 0;
            progressMerge.Value = 0;
            progressSelection.Value = 0;
            lblBurbuja.Text = "Burbuja: 0%";
            lblQuickSort.Text = "QuickSort: 0%";
            lblMergeSort.Text = "MergeSort: 0%";
            lblSelectionSort.Text = "Selection: 0%";
            chartTiempos.Series["Tiempos"].Points.Clear();
            txtBurbuja.Text = "";
            txtQuick.Text = "";
            txtMerge.Text = "";
            txtSelection.Text = "";
        }
    }   
}

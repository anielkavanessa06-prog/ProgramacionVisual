namespace OrdenamientoMultihilo
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Button btnDetener;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblBurbujaLabel;
        private System.Windows.Forms.TextBox txtBurbuja;
        private System.Windows.Forms.Label lblQuickLabel;
        private System.Windows.Forms.TextBox txtQuick;
        private System.Windows.Forms.Label lblMergeLabel;
        private System.Windows.Forms.TextBox txtMerge;
        private System.Windows.Forms.Label lblSelectionLabel;
        private System.Windows.Forms.TextBox txtSelection;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTiempos;
        private System.Windows.Forms.DataGridView dgvMuestra;
        private System.Windows.Forms.ProgressBar progressBurbuja;
        private System.Windows.Forms.ProgressBar progressQuickSort;
        private System.Windows.Forms.Label lblBurbuja;
        private System.Windows.Forms.Label lblQuickSort;
        private System.ComponentModel.BackgroundWorker backgroundWorkerQuickSort;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.btnDetener = new System.Windows.Forms.Button();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblBurbujaLabel = new System.Windows.Forms.Label();
            this.txtBurbuja = new System.Windows.Forms.TextBox();
            this.lblQuickLabel = new System.Windows.Forms.Label();
            this.txtQuick = new System.Windows.Forms.TextBox();
            this.lblMergeLabel = new System.Windows.Forms.Label();
            this.txtMerge = new System.Windows.Forms.TextBox();
            this.lblSelectionLabel = new System.Windows.Forms.Label();
            this.txtSelection = new System.Windows.Forms.TextBox();
            this.chartTiempos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dgvMuestra = new System.Windows.Forms.DataGridView();
            this.progressBurbuja = new System.Windows.Forms.ProgressBar();
            this.progressQuickSort = new System.Windows.Forms.ProgressBar();
            this.lblBurbuja = new System.Windows.Forms.Label();
            this.lblQuickSort = new System.Windows.Forms.Label();
            this.backgroundWorkerQuickSort = new System.ComponentModel.BackgroundWorker();
            this.lblMergeSort = new System.Windows.Forms.Label();
            this.lblSelectionSort = new System.Windows.Forms.Label();
            this.progressMerge = new System.Windows.Forms.ProgressBar();
            this.progressSelection = new System.Windows.Forms.ProgressBar();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnNuevoProceso = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartTiempos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMuestra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGenerar
            // 
            this.btnGenerar.BackColor = System.Drawing.Color.DarkOrange;
            this.btnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerar.ForeColor = System.Drawing.Color.White;
            this.btnGenerar.Location = new System.Drawing.Point(97, 21);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(140, 34);
            this.btnGenerar.TabIndex = 0;
            this.btnGenerar.Text = "Generar Datos";
            this.btnGenerar.UseVisualStyleBackColor = false;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // btnIniciar
            // 
            this.btnIniciar.BackColor = System.Drawing.Color.DarkOrange;
            this.btnIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciar.ForeColor = System.Drawing.Color.White;
            this.btnIniciar.Location = new System.Drawing.Point(97, 74);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(140, 34);
            this.btnIniciar.TabIndex = 1;
            this.btnIniciar.Text = "Iniciar Ordenamiento";
            this.btnIniciar.UseVisualStyleBackColor = false;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // btnDetener
            // 
            this.btnDetener.BackColor = System.Drawing.Color.DarkOrange;
            this.btnDetener.Enabled = false;
            this.btnDetener.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetener.ForeColor = System.Drawing.Color.White;
            this.btnDetener.Location = new System.Drawing.Point(97, 131);
            this.btnDetener.Name = "btnDetener";
            this.btnDetener.Size = new System.Drawing.Size(140, 34);
            this.btnDetener.TabIndex = 2;
            this.btnDetener.Text = "Detener";
            this.btnDetener.UseVisualStyleBackColor = false;
            this.btnDetener.Click += new System.EventHandler(this.btnDetener_Click);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(17, 408);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(179, 20);
            this.lblCantidad.TabIndex = 3;
            this.lblCantidad.Text = "Cantidad de Elementos:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(173, 402);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 26);
            this.txtCantidad.TabIndex = 4;
            this.txtCantidad.TextChanged += new System.EventHandler(this.txtCantidad_TextChanged);
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // lblBurbujaLabel
            // 
            this.lblBurbujaLabel.AutoSize = true;
            this.lblBurbujaLabel.Location = new System.Drawing.Point(68, 452);
            this.lblBurbujaLabel.Name = "lblBurbujaLabel";
            this.lblBurbujaLabel.Size = new System.Drawing.Size(68, 20);
            this.lblBurbujaLabel.TabIndex = 5;
            this.lblBurbujaLabel.Text = "Burbuja:";
            // 
            // txtBurbuja
            // 
            this.txtBurbuja.Location = new System.Drawing.Point(139, 446);
            this.txtBurbuja.Name = "txtBurbuja";
            this.txtBurbuja.Size = new System.Drawing.Size(150, 26);
            this.txtBurbuja.TabIndex = 6;
            // 
            // lblQuickLabel
            // 
            this.lblQuickLabel.AutoSize = true;
            this.lblQuickLabel.Location = new System.Drawing.Point(56, 489);
            this.lblQuickLabel.Name = "lblQuickLabel";
            this.lblQuickLabel.Size = new System.Drawing.Size(83, 20);
            this.lblQuickLabel.TabIndex = 7;
            this.lblQuickLabel.Text = "QuickSort:";
            // 
            // txtQuick
            // 
            this.txtQuick.Location = new System.Drawing.Point(139, 483);
            this.txtQuick.Name = "txtQuick";
            this.txtQuick.Size = new System.Drawing.Size(150, 26);
            this.txtQuick.TabIndex = 8;
            // 
            // lblMergeLabel
            // 
            this.lblMergeLabel.AutoSize = true;
            this.lblMergeLabel.Location = new System.Drawing.Point(56, 525);
            this.lblMergeLabel.Name = "lblMergeLabel";
            this.lblMergeLabel.Size = new System.Drawing.Size(88, 20);
            this.lblMergeLabel.TabIndex = 9;
            this.lblMergeLabel.Text = "MergeSort:";
            // 
            // txtMerge
            // 
            this.txtMerge.Location = new System.Drawing.Point(139, 519);
            this.txtMerge.Name = "txtMerge";
            this.txtMerge.Size = new System.Drawing.Size(150, 26);
            this.txtMerge.TabIndex = 10;
            // 
            // lblSelectionLabel
            // 
            this.lblSelectionLabel.AutoSize = true;
            this.lblSelectionLabel.Location = new System.Drawing.Point(39, 560);
            this.lblSelectionLabel.Name = "lblSelectionLabel";
            this.lblSelectionLabel.Size = new System.Drawing.Size(109, 20);
            this.lblSelectionLabel.TabIndex = 11;
            this.lblSelectionLabel.Text = "SelectionSort:";
            // 
            // txtSelection
            // 
            this.txtSelection.Location = new System.Drawing.Point(139, 554);
            this.txtSelection.Name = "txtSelection";
            this.txtSelection.Size = new System.Drawing.Size(150, 26);
            this.txtSelection.TabIndex = 12;
            // 
            // chartTiempos
            // 
            chartArea1.Name = "ChartArea1";
            this.chartTiempos.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartTiempos.Legends.Add(legend1);
            this.chartTiempos.Location = new System.Drawing.Point(410, 387);
            this.chartTiempos.Name = "chartTiempos";
            this.chartTiempos.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Tiempos";
            this.chartTiempos.Series.Add(series1);
            this.chartTiempos.Size = new System.Drawing.Size(386, 223);
            this.chartTiempos.TabIndex = 1;
            // 
            // dgvMuestra
            // 
            this.dgvMuestra.AllowUserToAddRows = false;
            this.dgvMuestra.AllowUserToDeleteRows = false;
            this.dgvMuestra.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMuestra.ColumnHeadersHeight = 29;
            this.dgvMuestra.Location = new System.Drawing.Point(565, 12);
            this.dgvMuestra.Name = "dgvMuestra";
            this.dgvMuestra.ReadOnly = true;
            this.dgvMuestra.RowHeadersWidth = 51;
            this.dgvMuestra.Size = new System.Drawing.Size(433, 335);
            this.dgvMuestra.TabIndex = 0;
            // 
            // progressBurbuja
            // 
            this.progressBurbuja.Location = new System.Drawing.Point(189, 195);
            this.progressBurbuja.Name = "progressBurbuja";
            this.progressBurbuja.Size = new System.Drawing.Size(220, 18);
            this.progressBurbuja.TabIndex = 14;
            this.progressBurbuja.Click += new System.EventHandler(this.progressBurbuja_Click);
            // 
            // progressQuickSort
            // 
            this.progressQuickSort.Location = new System.Drawing.Point(189, 249);
            this.progressQuickSort.Name = "progressQuickSort";
            this.progressQuickSort.Size = new System.Drawing.Size(220, 18);
            this.progressQuickSort.TabIndex = 16;
            // 
            // lblBurbuja
            // 
            this.lblBurbuja.AutoSize = true;
            this.lblBurbuja.Location = new System.Drawing.Point(17, 197);
            this.lblBurbuja.Name = "lblBurbuja";
            this.lblBurbuja.Size = new System.Drawing.Size(95, 20);
            this.lblBurbuja.TabIndex = 13;
            this.lblBurbuja.Text = "Burbuja: 0%";
            this.lblBurbuja.Click += new System.EventHandler(this.lblBurbuja_Click);
            // 
            // lblQuickSort
            // 
            this.lblQuickSort.AutoSize = true;
            this.lblQuickSort.Location = new System.Drawing.Point(12, 249);
            this.lblQuickSort.Name = "lblQuickSort";
            this.lblQuickSort.Size = new System.Drawing.Size(110, 20);
            this.lblQuickSort.TabIndex = 15;
            this.lblQuickSort.Text = "QuickSort: 0%";
            // 
            // backgroundWorkerQuickSort
            // 
            this.backgroundWorkerQuickSort.WorkerReportsProgress = true;
            this.backgroundWorkerQuickSort.WorkerSupportsCancellation = true;
            this.backgroundWorkerQuickSort.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerQuickSort_DoWork);
            this.backgroundWorkerQuickSort.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorkerQuickSort_ProgressChanged);
            this.backgroundWorkerQuickSort.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerQuickSort_RunWorkerCompleted);
            // 
            // lblMergeSort
            // 
            this.lblMergeSort.AutoSize = true;
            this.lblMergeSort.Location = new System.Drawing.Point(7, 295);
            this.lblMergeSort.Name = "lblMergeSort";
            this.lblMergeSort.Size = new System.Drawing.Size(115, 20);
            this.lblMergeSort.TabIndex = 17;
            this.lblMergeSort.Text = "MergeSort: 0%";
            this.lblMergeSort.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblSelectionSort
            // 
            this.lblSelectionSort.AutoSize = true;
            this.lblSelectionSort.Location = new System.Drawing.Point(7, 331);
            this.lblSelectionSort.Name = "lblSelectionSort";
            this.lblSelectionSort.Size = new System.Drawing.Size(132, 20);
            this.lblSelectionSort.TabIndex = 18;
            this.lblSelectionSort.Text = "SelectionSort 0%";
            // 
            // progressMerge
            // 
            this.progressMerge.Location = new System.Drawing.Point(189, 293);
            this.progressMerge.Name = "progressMerge";
            this.progressMerge.Size = new System.Drawing.Size(220, 18);
            this.progressMerge.TabIndex = 19;
            // 
            // progressSelection
            // 
            this.progressSelection.Location = new System.Drawing.Point(189, 329);
            this.progressSelection.Name = "progressSelection";
            this.progressSelection.Size = new System.Drawing.Size(220, 18);
            this.progressSelection.TabIndex = 20;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnNuevoProceso
            // 
            this.btnNuevoProceso.BackColor = System.Drawing.Color.DarkOrange;
            this.btnNuevoProceso.Enabled = false;
            this.btnNuevoProceso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoProceso.ForeColor = System.Drawing.Color.White;
            this.btnNuevoProceso.Location = new System.Drawing.Point(323, 74);
            this.btnNuevoProceso.Name = "btnNuevoProceso";
            this.btnNuevoProceso.Size = new System.Drawing.Size(140, 34);
            this.btnNuevoProceso.TabIndex = 21;
            this.btnNuevoProceso.Text = "Nuevo Proceso";
            this.btnNuevoProceso.UseVisualStyleBackColor = false;
            this.btnNuevoProceso.Click += new System.EventHandler(this.btnNuevoProceso_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(878, 648);
            this.Controls.Add(this.btnNuevoProceso);
            this.Controls.Add(this.progressSelection);
            this.Controls.Add(this.progressMerge);
            this.Controls.Add(this.lblSelectionSort);
            this.Controls.Add(this.lblMergeSort);
            this.Controls.Add(this.dgvMuestra);
            this.Controls.Add(this.chartTiempos);
            this.Controls.Add(this.progressQuickSort);
            this.Controls.Add(this.lblQuickSort);
            this.Controls.Add(this.progressBurbuja);
            this.Controls.Add(this.lblBurbuja);
            this.Controls.Add(this.txtSelection);
            this.Controls.Add(this.lblSelectionLabel);
            this.Controls.Add(this.txtMerge);
            this.Controls.Add(this.lblMergeLabel);
            this.Controls.Add(this.txtQuick);
            this.Controls.Add(this.lblQuickLabel);
            this.Controls.Add(this.txtBurbuja);
            this.Controls.Add(this.lblBurbujaLabel);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.btnDetener);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.btnGenerar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Ordenamiento Multihilo - Interfaz ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartTiempos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMuestra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMergeSort;
        private System.Windows.Forms.Label lblSelectionSort;
        private System.Windows.Forms.ProgressBar progressMerge;
        private System.Windows.Forms.ProgressBar progressSelection;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnNuevoProceso;
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MDIEstudiantes;
using System.Windows.Forms.DataVisualization.Charting;


namespace MDIEstudiantes

{
    public partial class Form4: Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // Limpiar cualquier serie de datos anterior del gráfico
            chartPromedios.Series.Clear();

            // Verificar si hay estudiantes en la lista
            if (DatosCompartidos.ListaEstudiantes.Count > 0)
            {
                // Crear una nueva serie para nuestro gráfico
                Series seriePromedios = new Series("Promedios Estudiantiles")
                {
                    ChartType = SeriesChartType.Column // Tipo de gráfico: Columnas (Barras)
                };

                // Añadir la serie al control Chart
                chartPromedios.Series.Add(seriePromedios);
                chartPromedios.Series["Promedios Estudiantiles"].IsValueShownAsLabel = true;


                // Configurar el área del gráfico (opcional, para mejor visualización)
                chartPromedios.ChartAreas[0].AxisX.Title = "Estudiante";
                chartPromedios.ChartAreas[0].AxisY.Title = "Promedio";
                chartPromedios.ChartAreas[0].AxisY.Minimum = 0;
                chartPromedios.ChartAreas[0].AxisY.Maximum = 100; // Asumiendo notas de 0 a 10

                // Recorrer la lista de estudiantes para calcular y añadir promedios
                foreach (var estudiante in DatosCompartidos.ListaEstudiantes)
                {
                    if (estudiante.Asignaturas.Any()) // Asegúrate de que tenga asignaturas
                    {
                        // Calcular el promedio de notas del estudiante
                        double promedio = estudiante.Asignaturas.Average(a => a.Nota);

                        // Añadir el punto al gráfico (Nombre del estudiante en X, Promedio en Y)
                        seriePromedios.Points.AddXY(estudiante.Nombre, promedio);
                    }
                    else
                    {
                        // Si no tiene asignaturas, puedes añadirlo con promedio 0 o ignorarlo
                        seriePromedios.Points.AddXY(estudiante.Nombre, 0);
                    }
                }

                // Mostrar un mensaje si no se puede generar el gráfico
                if (!seriePromedios.Points.Any())
                {
                    MessageBox.Show("No hay datos con promedios válidos para mostrar en el gráfico.");
                }
            }
            else
            {
                MessageBox.Show("No hay estudiantes para generar el gráfico de promedios.");
            }
        }
    }
}

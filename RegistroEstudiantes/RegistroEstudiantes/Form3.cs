using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDIEstudiantes
{
    public partial class Form3: Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        
       

       
        private void button1_Click(object sender, EventArgs e)
        {
          
            // 1. Obtener el carnet a buscar
            string carnetBuscado = txtCarnet.Text.Trim();

            // Limpiar campos y tabla antes de buscar
            txtNombre.Text = string.Empty;
            dgvAsignaturas.Rows.Clear();

            // 2. Validación de búsqueda
            if (string.IsNullOrEmpty(carnetBuscado))
            {
                MessageBox.Show("Por favor, ingrese un número de Carnet para buscar.");
                return;
            }

            // 3. Buscar el estudiante en la lista compartida
            // Usamos FirstOrDefault para encontrar al primer estudiante con ese Carnet
            var estudianteEncontrado = DatosCompartidos.ListaEstudiantes
                .FirstOrDefault(est => est.Carnet == carnetBuscado);

            // 4. Mostrar el resultado
            if (estudianteEncontrado != null)
            {
                // Mostrar el nombre
                txtNombre.Text = estudianteEncontrado.Nombre;

                // Limpiar y llenar el DataGridView con las asignaturas
                dgvAsignaturas.Rows.Clear();

                // Asegurarse de que el DGV tenga las columnas Asignatura y NotaFinal
                if (dgvAsignaturas.Columns.Count == 0)
                {
                    dgvAsignaturas.Columns.Add("AsignaturaCol", "Asignatura");
                    dgvAsignaturas.Columns.Add("NotaFinalCol", "Nota Final");
                }

                if (estudianteEncontrado.Asignaturas.Any())
                {
                    foreach (var asig in estudianteEncontrado.Asignaturas)
                    {
                        dgvAsignaturas.Rows.Add(asig.Nombre, asig.Nota);
                    }
                }
                else
                {
                    MessageBox.Show("Estudiante encontrado, pero no tiene asignaturas registradas.");
                }
            }
            else
            {
                MessageBox.Show($"No se encontró ningún estudiante con el Carnet: {carnetBuscado}");
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // Verificar si las columnas ya existen
            if (dataGridView1.Columns.Count == 0)
            {
                dataGridView1.Columns.Add("CarnetCol", "Carnet");
                dataGridView1.Columns.Add("NombreCol", "Nombre");
            }

            // Agregar los estudiantes a la tabla
            foreach (var aa in DatosCompartidos.ListaEstudiantes)
            {
                dataGridView1.Rows.Add(aa.Carnet, aa.Nombre);
            }
        }
    }
}
    

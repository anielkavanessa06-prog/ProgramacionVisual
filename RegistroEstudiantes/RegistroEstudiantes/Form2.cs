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

namespace MDIEstudiantes
{
    public partial class Form2: Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        

        private void btnGuardar_Click_1(object sender, EventArgs e) { 

            // 1. Crear la nueva instancia de Estudiante
            Estudiante estudiante = new Estudiante
            {
                Carnet = txtCarnet.Text,
                Nombre = txtNombre.Text
            };

            // 2. Recorrer el DataGridView para obtener las asignaturas
            foreach (DataGridViewRow fila in dgvAsignaturas.Rows)
            {
                // Verificar que ambas celdas (Nombre y Nota) no estén vacías
                if (fila.Cells[0].Value != null && fila.Cells[1].Value != null)
                {
                    // Crear y añadir la nueva Asignatura al estudiante
                    estudiante.Asignaturas.Add(new Asignatura
                    {
                        Nombre = fila.Cells[0].Value.ToString(),
                        // Convertir la nota a tipo double
                        Nota = Convert.ToDouble(fila.Cells[1].Value)
                    });
                }
            }

            // 3. Almacenar el estudiante en la clase de datos compartidos
            DatosCompartidos.ListaEstudiantes.Add(estudiante);

// 4. Mostrar mensaje y cerrar formulario
MessageBox.Show("Datos guardados correctamente");
//this.Close();
        txtCarnet.Text = "";
        txtNombre.Text = "";
        dgvAsignaturas.Rows.Clear();


        }

      
    }
}

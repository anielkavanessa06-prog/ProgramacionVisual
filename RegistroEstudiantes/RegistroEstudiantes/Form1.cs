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
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
       
       
        

      

        private void ingresarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Busca si ya existe una instancia de Form2 abierta
            Form form2 = Application.OpenForms.OfType<Form2>().FirstOrDefault();

            if (form2 == null)
            {
                // Si no existe, crea una nueva instancia
                form2 = new Form2();

                // Establece Form1 como el padre MDI
                form2.MdiParent = this;

                // Muestra el formulario
                form2.Show();
            }
            else
            {
                // Si ya existe, lo trae al frente
                form2.Focus();
            }
        }

        private void visualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Busca si ya existe una instancia de Form3 abierta
            Form form3 = Application.OpenForms.OfType<Form3>().FirstOrDefault();

            if (form3 == null)
            {
                // Si no existe, crea una nueva instancia
                form3 = new Form3();

                // Establece Form1 como el padre MDI
                form3.MdiParent = this;

                // Muestra el formulario
                form3.Show();
            }
            else
            {
                // Si ya existe, lo trae al frente
                form3.Focus();
            }
        }

        private void promediosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 1. Buscar si el formulario ya existe entre los hijos abiertos
            Form form4 = Application.OpenForms.OfType<Form4>().FirstOrDefault();

            if (form4 == null)
            {
                // 2. Si no existe, crear una nueva instancia
                form4 = new Form4();

                // 3. Establecer el contenedor padre MDI
                form4.MdiParent = this;

                // 4. Mostrar el formulario
                form4.Show();
            }
            else
            {
                // 5. Si ya existe, simplemente enfocarlo (traerlo al frente)
                form4.Focus();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualGuias
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int contaas;
       

        

        //
        int intentos = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            String Usuario = ctUsuario.Text;
            string Clave = ctClave.Text;
            if (Usuario == "admin" && Clave == "admin123")
            {
                MessageBox.Show("BIENVENIDO AL SISTEMA Admin");
                ctUsuario.Text = "";
                ctClave.Text = "";
            }
            else
            {
                if (ctUsuario.Text == "" || ctClave.Text == "")
                {
                    MessageBox.Show("Ingrese datos para continuar");
                    return; 
                }

                intentos++;
                int intentosrestantes = 3 - intentos;
                if (intentosrestantes > 0)
                {
                    MessageBox.Show(" Clave Incorrecta,Te queden : " + intentosrestantes + "Intentos");
                }
                else
                {

                    MessageBox.Show("Has excedido el numero de intentos");
                    Close();
                }

            }


        }
        private void button5_Click_1(object sender, EventArgs e)
        {
            contaas++;

            lblContador.Text = contaas.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    // Leer peso (kg) y altura (cm)
                    double peso = double.Parse(txtPeso.Text);
                    double alturaCm = double.Parse(txtAltura.Text);

                    // Convertir altura a metros
                    double alturaM = alturaCm / 100;

                    // Calcular IMC
                    double imc = peso / (alturaM * alturaM);

                    // Clasificación
                    string estado = "";

                    if (imc < 19)
                        estado = "Peso bajo";
                    else if (imc >= 19 && imc < 25)
                        estado = "Normal";
                    else if (imc >= 25 && imc < 30)
                        estado = "Sobrepeso";
                    else
                        estado = "Obesidad";

                    // Mostrar resultado como la app
                    MessageBox.Show(
                        $"Tu IMC es {imc:F1}\nEstado: {estado}",
                        "Resultado IMC",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                    txtPeso.Clear();
                    txtAltura.Clear();
                    txtPeso.Focus();
                }
                catch
                {
                    MessageBox.Show("Ingresa valores válidos para Peso (kg) y Altura (cm).", "Error");
                }
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(txtFahrenheit.Text))
                {
                    // Convertir de Fahrenheit a Celsius
                    double f = Convert.ToDouble(txtFahrenheit.Text);
                    double c = (f - 32) * 5 / 9;
                    txtCelcius.Text = $"{c:F2}";
                }
                else if (!string.IsNullOrWhiteSpace(txtCelcius.Text))
                {
                    // Convertir de Celsius a Fahrenheit
                    double c = Convert.ToDouble(txtCelcius.Text);
                    double f = (c * 9 / 5) + 32;
                    txtFahrenheit.Text = $"{f:F2}";
                }
                else
                {
                    MessageBox.Show("Por favor ingrese un valor en uno de los campos.");
                }
            }
            catch
            {
                MessageBox.Show("Error: ingrese un número válido.");
            }

        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            txtFahrenheit.Text = "";
            txtCelcius.Text = "";

        }

        private void btreini_Click(object sender, EventArgs e)
        {
            contaas = 0;
            lblContador.Text = contaas.ToString();
        }
    }
    }

    


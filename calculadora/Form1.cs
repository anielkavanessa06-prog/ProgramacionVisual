using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string operador = "";
        double num1 = 0;
        double num2 = 0;

    
        double memoria = 0;

        private void btlimpiar_Click(object sender, EventArgs e)
        {
            tbpantalla.Text = "0";
            num1 = 0;
            num2 = 0;
            operador = "";
        }

        private void btbor_Click(object sender, EventArgs e)
        {
            if (tbpantalla.TextLength == 1) tbpantalla.Text = "0";
            else tbpantalla.Text = tbpantalla.Text.Substring(0, tbpantalla.Text.Length - 1);
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (tbpantalla.Text == "0") tbpantalla.Text = "";
            tbpantalla.Text = tbpantalla.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (tbpantalla.Text == "0") tbpantalla.Text = "";
            tbpantalla.Text = tbpantalla.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (tbpantalla.Text == "0") tbpantalla.Text = "";
            tbpantalla.Text = tbpantalla.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (tbpantalla.Text == "0") tbpantalla.Text = "";
            tbpantalla.Text = tbpantalla.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (tbpantalla.Text == "0") tbpantalla.Text = "";
            tbpantalla.Text = tbpantalla.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (tbpantalla.Text == "0") tbpantalla.Text = "";
            tbpantalla.Text = tbpantalla.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (tbpantalla.Text == "0") tbpantalla.Text = "";
            tbpantalla.Text = tbpantalla.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (tbpantalla.Text == "0") tbpantalla.Text = "";
            tbpantalla.Text = tbpantalla.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (tbpantalla.Text == "0") tbpantalla.Text = "";
            tbpantalla.Text = tbpantalla.Text + "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (tbpantalla.Text != "0")
                tbpantalla.Text += "0";
        }


        private void btpun_Click(object sender, EventArgs e)
        {
            if (!tbpantalla.Text.Contains(","))
                tbpantalla.Text+=",";
        }

        private void btsumar_Click(object sender, EventArgs e)
        {
            operador = "+";
            num1 = Convert.ToDouble(tbpantalla.Text);
            tbpantalla.Text = "0";

        }

        private void btresta_Click(object sender, EventArgs e)
        {
            operador = "-";
            num1 = Convert.ToDouble(tbpantalla.Text);
            tbpantalla.Text = "0";

        }

        private void btmulti_Click(object sender, EventArgs e)
        {
            operador = "*";
            num1 = Convert.ToDouble(tbpantalla.Text);
            tbpantalla.Text = "0";

        }

        private void btdivi_Click(object sender, EventArgs e)
        {
            operador = "/";
            num1 = Convert.ToDouble(tbpantalla.Text);
            tbpantalla.Text = "0";

        }
        private void btExp_Click(object sender, EventArgs e)
        {
            operador = "^";
            num1 = Convert.ToDouble(tbpantalla.Text);
            tbpantalla.Text = "0";
        }

        private void btigual_Click(object sender, EventArgs e)
        {
            num2 = Convert.ToDouble(tbpantalla.Text);

            switch (operador)
            {
                case "+":
                    tbpantalla.Text = $"{num1 + num2}";
                    break;

                case "-":
                    tbpantalla.Text = $"{num1 - num2}";
                    break;

                case "*":
                    tbpantalla.Text = $"{num1 * num2}";
                    break;

                case "/":
                    if (num2 == 0) tbpantalla.Text = "Error";
                    else tbpantalla.Text = $"{num1 / num2}";
                    break;

              
                case "^":
                    tbpantalla.Text = $"{Math.Pow(num1, num2)}";
                    break;
            }
        }


        private void btMmas_Click(object sender, EventArgs e)
        {
            if (double.TryParse(tbpantalla.Text, out double valor))
                memoria += valor;
            else
                tbpantalla.Text = "Error";

        }

        private void btMme_Click(object sender, EventArgs e)
        {
            memoria -= Convert.ToDouble(tbpantalla.Text);
        }

        private void btMc_Click(object sender, EventArgs e)
        {
            memoria = 0;
        }

        private void btMmr_Click(object sender, EventArgs e)
        {
            tbpantalla.Text = memoria.ToString();
        }

        private void btRai_Click(object sender, EventArgs e)
        {
            double valor = Convert.ToDouble(tbpantalla.Text);
            if (valor < 0) tbpantalla.Text = "Error";
            else tbpantalla.Text = Math.Sqrt(valor).ToString();
        }

        private void btPi_Click(object sender, EventArgs e)
        {
            tbpantalla.Text = Math.PI.ToString();
        }

        private void btLog_Click(object sender, EventArgs e)
        {
            double valor = Convert.ToDouble(tbpantalla.Text);
            if (valor <= 0) tbpantalla.Text = "Error";
            else tbpantalla.Text = Math.Log10(valor).ToString();
        }

    

       

    
        

        private void btFact_Click(object sender, EventArgs e)
        {
            double valor = Convert.ToDouble(tbpantalla.Text);   // lee el valor en grados
            double radianes = valor * Math.PI / 180;            // lo pasa a radianes

            // Validar ángulos donde no existe tangente (90°, 270°, etc.)
            double coseno = Math.Cos(radianes);
            if (Math.Abs(coseno) < 1e-10)                       // aproximación a cero
                tbpantalla.Text = "Error";
            else
                tbpantalla.Text = Math.Tan(radianes).ToString();

        }

        private void btSin_Click(object sender, EventArgs e)
        {
            double valor = Convert.ToDouble(tbpantalla.Text);   
            double radianes = valor * Math.PI / 180;            
            tbpantalla.Text = Math.Sin(radianes).ToString();
        }

        private void btCose_Click(object sender, EventArgs e)
        {
            double valor = Convert.ToDouble(tbpantalla.Text);   // lee el valor en grados
            double radianes = valor * Math.PI / 180;            // lo pasa a radianes
            tbpantalla.Text = Math.Cos(radianes).ToString();
        }

        private void btPorsentaje_Click(object sender, EventArgs e)
        {
            if (double.TryParse(tbpantalla.Text, out double valor))
            {
                tbpantalla.Text = (valor / 100).ToString();
            }
            else
            {
                tbpantalla.Text = "Error";
            }

        }
    }
}
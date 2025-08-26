namespace VisualGuias
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btlimpim = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.txtCelcius = new System.Windows.Forms.TextBox();
            this.txtFahrenheit = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnConvertir = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ctClave = new System.Windows.Forms.TextBox();
            this.ctUsuario = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Bntclics = new System.Windows.Forms.TabPage();
            this.lblContador = new System.Windows.Forms.Label();
            this.BtnClic = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.btreini = new System.Windows.Forms.Button();
            this.tabPage4.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.Bntclics.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btlimpim);
            this.tabPage4.Controls.Add(this.btnCalcular);
            this.tabPage4.Controls.Add(this.txtAltura);
            this.tabPage4.Controls.Add(this.txtPeso);
            this.tabPage4.Controls.Add(this.textBox6);
            this.tabPage4.Controls.Add(this.textBox5);
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(499, 417);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "IMC";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btlimpim
            // 
            this.btlimpim.Location = new System.Drawing.Point(0, 0);
            this.btlimpim.Name = "btlimpim";
            this.btlimpim.Size = new System.Drawing.Size(75, 23);
            this.btlimpim.TabIndex = 0;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(160, 225);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(125, 29);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "CALCULA";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(271, 104);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(109, 26);
            this.txtAltura.TabIndex = 3;
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(271, 36);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(125, 26);
            this.txtPeso.TabIndex = 2;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(67, 104);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(161, 26);
            this.textBox6.TabIndex = 1;
            this.textBox6.Text = "Ingrese su altura (m)";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(67, 37);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(161, 26);
            this.textBox5.TabIndex = 0;
            this.textBox5.Text = "Ingrese su peso (kg)";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.BtnLimpiar);
            this.tabPage3.Controls.Add(this.txtCelcius);
            this.tabPage3.Controls.Add(this.txtFahrenheit);
            this.tabPage3.Controls.Add(this.textBox2);
            this.tabPage3.Controls.Add(this.textBox1);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.BtnConvertir);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(499, 417);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Conversor";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.Location = new System.Drawing.Point(238, 257);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(115, 33);
            this.BtnLimpiar.TabIndex = 6;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = true;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // txtCelcius
            // 
            this.txtCelcius.Location = new System.Drawing.Point(250, 128);
            this.txtCelcius.Name = "txtCelcius";
            this.txtCelcius.Size = new System.Drawing.Size(133, 26);
            this.txtCelcius.TabIndex = 5;
            // 
            // txtFahrenheit
            // 
            this.txtFahrenheit.Location = new System.Drawing.Point(250, 66);
            this.txtFahrenheit.Name = "txtFahrenheit";
            this.txtFahrenheit.Size = new System.Drawing.Size(133, 26);
            this.txtFahrenheit.TabIndex = 4;
            this.txtFahrenheit.Text = "56";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(86, 128);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 26);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "Celcius";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(86, 66);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Fahrenheit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(94, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 1;
            // 
            // BtnConvertir
            // 
            this.BtnConvertir.Location = new System.Drawing.Point(86, 257);
            this.BtnConvertir.Name = "BtnConvertir";
            this.BtnConvertir.Size = new System.Drawing.Size(118, 34);
            this.BtnConvertir.TabIndex = 0;
            this.BtnConvertir.Text = "Convertir";
            this.BtnConvertir.UseVisualStyleBackColor = true;
            this.BtnConvertir.Click += new System.EventHandler(this.button3_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ctClave);
            this.tabPage2.Controls.Add(this.ctUsuario);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(499, 417);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ingrese";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ctClave
            // 
            this.ctClave.Location = new System.Drawing.Point(206, 130);
            this.ctClave.Name = "ctClave";
            this.ctClave.PasswordChar = '*';
            this.ctClave.Size = new System.Drawing.Size(181, 26);
            this.ctClave.TabIndex = 5;
            this.ctClave.Tag = "";
            // 
            // ctUsuario
            // 
            this.ctUsuario.Location = new System.Drawing.Point(206, 57);
            this.ctUsuario.Name = "ctUsuario";
            this.ctUsuario.Size = new System.Drawing.Size(181, 26);
            this.ctUsuario.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(224, 231);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 38);
            this.button1.TabIndex = 4;
            this.button1.Text = "Ingresar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Contraseña";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuario:";
            // 
            // Bntclics
            // 
            this.Bntclics.Controls.Add(this.btreini);
            this.Bntclics.Controls.Add(this.lblContador);
            this.Bntclics.Controls.Add(this.BtnClic);
            this.Bntclics.Location = new System.Drawing.Point(4, 29);
            this.Bntclics.Name = "Bntclics";
            this.Bntclics.Padding = new System.Windows.Forms.Padding(3);
            this.Bntclics.Size = new System.Drawing.Size(499, 417);
            this.Bntclics.TabIndex = 0;
            this.Bntclics.Text = "Contador";
            this.Bntclics.UseVisualStyleBackColor = true;
            // 
            // lblContador
            // 
            this.lblContador.AutoSize = true;
            this.lblContador.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContador.Location = new System.Drawing.Point(175, 64);
            this.lblContador.Name = "lblContador";
            this.lblContador.Size = new System.Drawing.Size(99, 108);
            this.lblContador.TabIndex = 1;
            this.lblContador.Text = "0";
            // 
            // BtnClic
            // 
            this.BtnClic.Location = new System.Drawing.Point(69, 213);
            this.BtnClic.Name = "BtnClic";
            this.BtnClic.Size = new System.Drawing.Size(140, 48);
            this.BtnClic.TabIndex = 0;
            this.BtnClic.Text = "Contador ";
            this.BtnClic.UseVisualStyleBackColor = true;
            this.BtnClic.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Bntclics);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(507, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // btreini
            // 
            this.btreini.Location = new System.Drawing.Point(255, 213);
            this.btreini.Name = "btreini";
            this.btreini.Size = new System.Drawing.Size(126, 48);
            this.btreini.TabIndex = 2;
            this.btreini.Text = "Reiniciar";
            this.btreini.UseVisualStyleBackColor = true;
            this.btreini.Click += new System.EventHandler(this.btreini_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.Bntclics.ResumeLayout(false);
            this.Bntclics.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.TextBox txtCelcius;
        private System.Windows.Forms.TextBox txtFahrenheit;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnConvertir;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox ctClave;
        private System.Windows.Forms.TextBox ctUsuario;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage Bntclics;
        private System.Windows.Forms.Label lblContador;
        private System.Windows.Forms.Button BtnClic;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button btlimpim;
        private System.Windows.Forms.Button btreini;
    }
}


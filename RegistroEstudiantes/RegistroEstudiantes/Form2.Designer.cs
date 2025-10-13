namespace MDIEstudiantes
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtCarnet = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.dgvAsignaturas = new System.Windows.Forms.DataGridView();
            this.Asignatura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Notafinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsignaturas)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCarnet
            // 
            this.txtCarnet.Location = new System.Drawing.Point(317, 88);
            this.txtCarnet.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCarnet.Name = "txtCarnet";
            this.txtCarnet.Size = new System.Drawing.Size(177, 26);
            this.txtCarnet.TabIndex = 0;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(317, 151);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(177, 26);
            this.txtNombre.TabIndex = 1;
            // 
            // dgvAsignaturas
            // 
            this.dgvAsignaturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAsignaturas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Asignatura,
            this.Notafinal});
            this.dgvAsignaturas.Location = new System.Drawing.Point(223, 200);
            this.dgvAsignaturas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvAsignaturas.Name = "dgvAsignaturas";
            this.dgvAsignaturas.RowHeadersWidth = 51;
            this.dgvAsignaturas.RowTemplate.Height = 24;
            this.dgvAsignaturas.Size = new System.Drawing.Size(388, 229);
            this.dgvAsignaturas.TabIndex = 2;
           
            // Asignatura
            // 
            this.Asignatura.HeaderText = "Asignatura";
            this.Asignatura.MinimumWidth = 6;
            this.Asignatura.Name = "Asignatura";
            this.Asignatura.Width = 125;
            // 
            // Notafinal
            // 
            this.Notafinal.HeaderText = "NotaFinal";
            this.Notafinal.MinimumWidth = 6;
            this.Notafinal.Name = "Notafinal";
            this.Notafinal.Width = 125;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(339, 460);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(84, 29);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(243, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Carnet";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(243, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombre";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dgvAsignaturas);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCarnet);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsignaturas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCarnet;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.DataGridView dgvAsignaturas;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Asignatura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Notafinal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
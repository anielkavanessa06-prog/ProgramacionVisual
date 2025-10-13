namespace MDIEstudiantes
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCarnet = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.dgvAsignaturas = new System.Windows.Forms.DataGridView();
            this.Asignaturas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NotaFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dgvCarnet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsignaturas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(188, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Carnet";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(188, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre";
            // 
            // txtCarnet
            // 
            this.txtCarnet.Location = new System.Drawing.Point(251, 79);
            this.txtCarnet.Name = "txtCarnet";
            this.txtCarnet.Size = new System.Drawing.Size(179, 22);
            this.txtCarnet.TabIndex = 0;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(251, 118);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(179, 22);
            this.txtNombre.TabIndex = 1;
            // 
            // dgvAsignaturas
            // 
            this.dgvAsignaturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAsignaturas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Asignaturas,
            this.NotaFinal});
            this.dgvAsignaturas.Location = new System.Drawing.Point(468, 190);
            this.dgvAsignaturas.Name = "dgvAsignaturas";
            this.dgvAsignaturas.RowHeadersWidth = 51;
            this.dgvAsignaturas.RowTemplate.Height = 24;
            this.dgvAsignaturas.Size = new System.Drawing.Size(319, 222);
            this.dgvAsignaturas.TabIndex = 5;
            // 
            // Asignaturas
            // 
            this.Asignaturas.HeaderText = "Asignaturas";
            this.Asignaturas.MinimumWidth = 6;
            this.Asignaturas.Name = "Asignaturas";
            this.Asignaturas.ReadOnly = true;
            this.Asignaturas.Width = 125;
            // 
            // NotaFinal
            // 
            this.NotaFinal.HeaderText = "NotaFinal";
            this.NotaFinal.MinimumWidth = 6;
            this.NotaFinal.Name = "NotaFinal";
            this.NotaFinal.ReadOnly = true;
            this.NotaFinal.Width = 125;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(492, 98);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvCarnet,
            this.dgvNombre});
            this.dataGridView1.Location = new System.Drawing.Point(92, 190);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(322, 226);
            this.dataGridView1.TabIndex = 7;
            // 
            // dgvCarnet
            // 
            this.dgvCarnet.HeaderText = "Carnet";
            this.dgvCarnet.MinimumWidth = 6;
            this.dgvCarnet.Name = "dgvCarnet";
            this.dgvCarnet.ReadOnly = true;
            this.dgvCarnet.Width = 125;
            // 
            // dgvNombre
            // 
            this.dgvNombre.HeaderText = "Nombre";
            this.dgvNombre.MinimumWidth = 6;
            this.dgvNombre.Name = "dgvNombre";
            this.dgvNombre.ReadOnly = true;
            this.dgvNombre.Width = 125;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 509);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvAsignaturas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCarnet);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsignaturas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCarnet;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.DataGridView dgvAsignaturas;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Asignaturas;
        private System.Windows.Forms.DataGridViewTextBoxColumn NotaFinal;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCarnet;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNombre;
    }
}
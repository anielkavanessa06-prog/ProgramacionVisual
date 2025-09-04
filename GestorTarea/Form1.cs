using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GestorTarea
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class Tarea
        {
            public string Codigo { get; set; }
            public string Nombre { get; set; }
            public string Descripcion { get; set; }
            public DateTime Fecha { get; set; }
            public string Lugar { get; set; }
            public string Estado { get; set; }
        }

        List<Tarea> listaTareas = new List<Tarea>();

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbEstado.Items.Clear();
            cmbEstado.Items.AddRange(new string[] { "Pendiente", "En Proceso", "Completada" });

            cmbBuscarEstado.Items.Clear();
            cmbBuscarEstado.Items.AddRange(new string[] { "Pendiente", "En Proceso", "Completada" });

            dtpFechaInicial.Format = DateTimePickerFormat.Short;
            dtpFechaFin.Format = DateTimePickerFormat.Short;
        }

        private void ActualizarGrid()
        {
            dgvTareas.DataSource = null;
            dgvTareas.DataSource = listaTareas;
        }

        private void LimpiarCampos()
        {
            txtCodigo.Clear();
            txtNombre.Clear();
            txtDescripcion.Clear();
            txtLugar.Clear();
            cmbEstado.SelectedIndex = -1;
            txtBuscarCodigo.Clear();
            cmbBuscarEstado.SelectedIndex = -1;
            dtpFecha.Value = DateTime.Now;
            dtpFechaInicial.Value = DateTime.Now;
            dtpFechaFin.Value = DateTime.Now;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodigo.Text) ||
                string.IsNullOrWhiteSpace(txtNombre.Text) ||
                cmbEstado.SelectedItem == null)
            {
                MessageBox.Show("Por favor, complete los campos obligatorios.");
                return;
            }

            Tarea nueva = new Tarea()
            {
                Codigo = txtCodigo.Text,
                Nombre = txtNombre.Text,
                Descripcion = txtDescripcion.Text,
                Fecha = dtpFecha.Value,
                Lugar = txtLugar.Text,
                Estado = cmbEstado.SelectedItem.ToString()
            };

            listaTareas.Add(nueva);
            ActualizarGrid();
            MessageBox.Show("Tarea agregada correctamente.");
            LimpiarCampos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvTareas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, selecciona una tarea en la tabla para editar.");
                return;
            }

            int index = dgvTareas.SelectedRows[0].Index;

            if (index >= 0 && index < listaTareas.Count)
            {
                Tarea tareaSeleccionada = listaTareas[index];

                txtCodigo.Text = tareaSeleccionada.Codigo;
                txtNombre.Text = tareaSeleccionada.Nombre;
                txtDescripcion.Text = tareaSeleccionada.Descripcion;
                dtpFecha.Value = tareaSeleccionada.Fecha;
                txtLugar.Text = tareaSeleccionada.Lugar;

                if (cmbEstado.Items.Contains(tareaSeleccionada.Estado))
                {
                    cmbEstado.SelectedItem = tareaSeleccionada.Estado;
                }
                else
                {
                    cmbEstado.SelectedIndex = -1;
                }

                MessageBox.Show("Datos cargados. Ahora podés modificar y guardar los cambios.");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvTareas.SelectedRows.Count > 0)
            {
                int index = dgvTareas.SelectedRows[0].Index;
                listaTareas.RemoveAt(index);
                ActualizarGrid();
                MessageBox.Show("Tarea eliminada correctamente.");
                LimpiarCampos();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarTareas();
        }

        private void BuscarTareas()
        {
            List<Tarea> resultado = listaTareas;

            // Buscar solo por código si se ingresó
            if (!string.IsNullOrWhiteSpace(txtBuscarCodigo.Text))
            {
                resultado = resultado
                    .Where(t => t.Codigo.Equals(txtBuscarCodigo.Text, StringComparison.OrdinalIgnoreCase))
                    .ToList();
            }
            // Buscar solo por estado si se seleccionó
            else if (cmbBuscarEstado.SelectedItem != null)
            {
                resultado = resultado
                    .Where(t => t.Estado.Equals(cmbBuscarEstado.SelectedItem.ToString(), StringComparison.OrdinalIgnoreCase))
                    .ToList();
            }
            // Buscar solo por rango de fechas si se seleccionó un rango válido
            else
            {
                DateTime inicio = dtpFechaInicial.Value.Date;
                DateTime fin = dtpFechaFin.Value.Date;

                if (inicio > fin)
                {
                    MessageBox.Show("La fecha de inicio no puede ser mayor que la fecha final.", "Rango inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                resultado = resultado
                    .Where(t => t.Fecha.Date >= inicio && t.Fecha.Date <= fin)
                    .ToList();
            }

            dgvTareas.DataSource = null;
            dgvTareas.DataSource = resultado;
        }

        private void btnMostrarTodo_Click(object sender, EventArgs e)
        {
            ActualizarGrid();
            LimpiarCampos();
        }

        private void dgvTareas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtCodigo.Text = dgvTareas.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtNombre.Text = dgvTareas.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtDescripcion.Text = dgvTareas.Rows[e.RowIndex].Cells[2].Value.ToString();
                dtpFecha.Value = (DateTime)dgvTareas.Rows[e.RowIndex].Cells[3].Value;
                txtLugar.Text = dgvTareas.Rows[e.RowIndex].Cells[4].Value.ToString();

                string estado = dgvTareas.Rows[e.RowIndex].Cells[5].Value.ToString();
                if (cmbEstado.Items.Contains(estado))
                {
                    cmbEstado.SelectedItem = estado;
                }
                else
                {
                    cmbEstado.SelectedIndex = -1;
                }
            }
        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            if (dgvTareas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona una tarea para guardar los cambios.");
                return;
            }

            int index = dgvTareas.SelectedRows[0].Index;

            if (index >= 0 && index < listaTareas.Count)
            {
                listaTareas[index].Codigo = txtCodigo.Text;
                listaTareas[index].Nombre = txtNombre.Text;
                listaTareas[index].Descripcion = txtDescripcion.Text;
                listaTareas[index].Fecha = dtpFecha.Value;
                listaTareas[index].Lugar = txtLugar.Text;
                listaTareas[index].Estado = cmbEstado.SelectedItem?.ToString() ?? "";

                ActualizarGrid();
                MessageBox.Show("Cambios guardados correctamente.");
                LimpiarCampos();
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CadNatura;
using ClnNatura;

namespace CpNatura
{
    public partial class FrmCita : Form
    {
        bool esNuevo = false;
        public FrmCita()
        {
            InitializeComponent();
        }

        private void listar()
        {
            var citas = CitaCln.listarPa(txtParametro.Text.Trim());
            dgvLista.DataSource = citas;
            dgvLista.Columns["id"].Visible = false;
            dgvLista.Columns["estado"].Visible = false;
            dgvLista.Columns["idPaciente"].Visible = false;
            dgvLista.Columns["fecha"].HeaderText = "Fecha de Consulta";
            dgvLista.Columns["hora"].HeaderText = "Hora de Consulta";
            dgvLista.Columns["motivo"].HeaderText = "Motivo";
            dgvLista.Columns["usuarioRegistro"].HeaderText = "Usuario";
            dgvLista.Columns["fechaRegistro"].HeaderText = "Fecha de Registro";
            btnEditar.Enabled = citas.Count > 0;
            btnEliminar.Enabled = citas.Count > 0;
            if (citas.Count > 0) dgvLista.Rows[0].Cells["motivo"].Selected = true;
        }

        private void cargarPaciente()
        {
            cbxPaciente.DataSource = PacienteCln.listar();
            cbxPaciente.DisplayMember = "nombre";
            cbxPaciente.ValueMember = "id";
        }

        private void FrmCita_Load(object sender, EventArgs e)
        {
            pnlDatos.Visible = false;
            listar();
            cargarPaciente();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            esNuevo = true;
            pnlDatos.Visible = true;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            esNuevo = false;
            pnlDatos.Visible = true;

            int index = dgvLista.CurrentCell.RowIndex;
            int id = Convert.ToInt32(dgvLista.Rows[index].Cells["id"].Value);
            var cita = CitaCln.get(id);
            var paciente = PacienteCln.get(id);
            cbxPaciente.Text = paciente.nombre;
            dtpFecha.Value = cita.fecha;
            txtMotivo.Text = cita.motivo;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            pnlDatos.Visible = false;
            limpiar();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            listar();
        }

        private void txtParametro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) listar();
        }

        private bool validar()
        {
            bool esValido = true;
            erpPaciente.SetError(cbxPaciente, "");
            erpMotivo.SetError(txtMotivo, "");
            if (string.IsNullOrEmpty(cbxPaciente.Text))
            {
                esValido = false;
                erpPaciente.SetError(cbxPaciente, "El campo Nombre del Paciente es obligatorio");
            }
            if (string.IsNullOrEmpty(txtMotivo.Text))
            {
                esValido = false;
                erpMotivo.SetError(txtMotivo, "El campo Motivo es obligatorio");
            }
            return esValido;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                var cita = new Cita();
                cita.fecha = dtpFecha.Value;
                cita.hora = dtpHora.Value.TimeOfDay;
                cita.motivo = txtMotivo.Text.Trim();
                cita.usuarioRegistro = "Edward";
                if (esNuevo)
                {
                    cita.fechaRegistro = DateTime.Now;
                    cita.estado = 1;
                    cita.idPaciente = Convert.ToInt32(cbxPaciente.SelectedValue);
                    CitaCln.insertar(cita);
                }
                else
                {
                    int index = dgvLista.CurrentCell.RowIndex;
                    cita.id = Convert.ToInt32(dgvLista.Rows[index].Cells["id"].Value);
                    CitaCln.actualizar(cita);
                }
                listar();
                btnCancelar.PerformClick();
                MessageBox.Show("Cita registrada correctamente", "::: Natura - Mensaje:::",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void limpiar()
        {
            cbxPaciente.Text = string.Empty;
            dtpFecha.Value = DateTime.Now;
            dtpHora.Value = DateTime.Now;
            txtMotivo.Text = string.Empty;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int index = dgvLista.CurrentCell.RowIndex;
            int id = Convert.ToInt32(dgvLista.Rows[index].Cells["id"].Value);

            string fecha = dgvLista.Rows[index].Cells["fecha"].Value.ToString();
            DialogResult dialog = MessageBox.Show($"¿Está seguro que desea eliminar la Cita {fecha}?",
                "::: Natura - Mensaje :::", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialog == DialogResult.OK)
            {
                CitaCln.eliminar(id, "Edward");
                listar();
                MessageBox.Show("Cita eliminada correctamente", "::: Natura - Mensaje:::",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

using ClnNatura;
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

namespace CpNatura
{
    public partial class FrmReconsulta : Form
    {
        bool esNuevo = false;
        public FrmReconsulta()
        {
            InitializeComponent();
        }
        private void listar()
        {
            var reconsultas = ReconsultaCln.listarPa(txtParametro.Text.Trim());
            dgvLista.DataSource = reconsultas;
            dgvLista.Columns["id"].Visible = false;
            dgvLista.Columns["estado"].Visible = false;
            dgvLista.Columns["idCita"].Visible = false;
            dgvLista.Columns["fecha"].HeaderText = "Fecha de Reconsulta";
            dgvLista.Columns["hora"].HeaderText = "Hora de Reconsulta";
            dgvLista.Columns["motivo"].HeaderText = "Motivo";
            dgvLista.Columns["usuarioRegistro"].HeaderText = "Usuario";
            dgvLista.Columns["fechaRegistro"].HeaderText = "Fecha de Registro";
            btnEditar.Enabled = reconsultas.Count > 0;
            btnEliminar.Enabled = reconsultas.Count > 0;
            if (reconsultas.Count > 0) dgvLista.Rows[0].Cells["motivo"].Selected = true;
        }

        private void cargarCita()
        {
            cbxMotivo.DataSource = CitaCln.listar();
            cbxMotivo.DisplayMember = "motivo";
            cbxMotivo.ValueMember = "id";
        }

        private void FrmReconsulta_Load(object sender, EventArgs e)
        {
            pnlDatos.Visible = false;
            listar();
            cargarCita();
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
            var reconsulta = ReconsultaCln.get(id);
            cbxMotivo.Text = cita.motivo;
            dtpFecha.Value = reconsulta.fecha;
            txtMotivo.Text = reconsulta.motivo;
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
            erpCita.SetError(cbxMotivo, "");
            erpMotivo.SetError(txtMotivo, "");
            if (string.IsNullOrEmpty(cbxMotivo.Text))
            {
                esValido = false;
                erpCita.SetError(cbxMotivo, "El campo Motivo de Consulta del Paciente es obligatorio");
            }
            if (string.IsNullOrEmpty(txtMotivo.Text))
            {
                esValido = false;
                erpMotivo.SetError(txtMotivo, "El campo Motivo de Reconsulta es obligatorio");
            }
            return esValido;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                var reconsulta = new Reconsulta();
                reconsulta.fecha = dtpFecha.Value;
                reconsulta.hora = dtpHora.Value.TimeOfDay;
                reconsulta.motivo = txtMotivo.Text.Trim();
                reconsulta.usuarioRegistro = "Edward";
                if (esNuevo)
                {
                    reconsulta.fechaRegistro = DateTime.Now;
                    reconsulta.estado = 1;
                    reconsulta.idCita = Convert.ToInt32(cbxMotivo.SelectedValue);
                    ReconsultaCln.insertar(reconsulta);
                }
                else
                {
                    int index = dgvLista.CurrentCell.RowIndex;
                    reconsulta.id = Convert.ToInt32(dgvLista.Rows[index].Cells["id"].Value);
                    ReconsultaCln.actualizar(reconsulta);
                }
                listar();
                btnCancelar.PerformClick();
                MessageBox.Show("Reconsulta registrada correctamente", "::: Natura - Mensaje:::",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void limpiar()
        {
            cbxMotivo.Text = string.Empty;
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
                MessageBox.Show("Reconsulta eliminada correctamente", "::: Natura - Mensaje:::",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

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
    public partial class FrmPago : Form
    {
        bool esNuevo = false;
        public FrmPago()
        {
            InitializeComponent();
        }
        private void listar()
        {
            var pagos = PagoCln.listarPa(txtParametro.Text.Trim());
            dgvLista.DataSource = pagos;
            dgvLista.Columns["id"].Visible = false;
            dgvLista.Columns["estado"].Visible = false;
            dgvLista.Columns["idCita"].Visible = false;
            dgvLista.Columns["importe"].HeaderText = "Importe";
            dgvLista.Columns["saldo"].HeaderText = "Saldo";
            dgvLista.Columns["usuarioRegistro"].HeaderText = "Usuario";
            dgvLista.Columns["fechaRegistro"].HeaderText = "Fecha de Registro";
            btnEditar.Enabled = pagos.Count > 0;
            btnEliminar.Enabled = pagos.Count > 0;
            if (pagos.Count > 0) dgvLista.Rows[0].Cells["estado"].Selected = true;
        }

        private void cargarCita()
        {
            cbxCitaFecha.DataSource = CitaCln.listar();
            cbxCitaFecha.DisplayMember = "fecha";
            cbxCitaFecha.ValueMember = "id";
            cbxCitaHora.DataSource = CitaCln.listar();
            cbxCitaHora.DisplayMember = "hora";
            cbxCitaHora.ValueMember = "id";

        }

        private void FrmPago_Load(object sender, EventArgs e)
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
            var pago = PagoCln.get(id);
            var cita = CitaCln.get(id);
            cbxCitaFecha.Text = cita.fecha.ToString("dd/mm/yyyy");
            cbxCitaHora.Text = cita.hora.ToString();
            nupImporte.Value = pago.importe;
            cbxSaldo.Text = pago.saldo;
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
            erpIdCita.SetError(cbxCitaFecha, "");
            erpImporte.SetError(nupImporte, "");
            erpSaldo.SetError(cbxSaldo, "");
            if (string.IsNullOrEmpty(cbxCitaFecha.Text))
            {
                esValido = false;
                erpIdCita.SetError(cbxCitaFecha, "El campo Motivo es obligatorio");
            }
            if (nupImporte.Value < 0)
            {
                esValido = false;
                erpImporte.SetError(nupImporte, "El campo Importe debe ser mayor a cero");
            }
            if (string.IsNullOrEmpty(cbxSaldo.Text))
            {
                esValido = false;
                erpSaldo.SetError(cbxSaldo, "El campo Saldo es obligatorio");
            }
            return esValido;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                var pago = new Pago();
                pago.importe = nupImporte.Value;
                pago.saldo = cbxSaldo.Text.Trim();
                pago.usuarioRegistro = "Edward";
                if (esNuevo)
                {
                    pago.fechaRegistro = DateTime.Now;
                    pago.estado = 1;
                    pago.idCita = Convert.ToInt32(cbxCitaFecha.SelectedValue);
                    pago.idCita = Convert.ToInt32(cbxCitaHora.SelectedValue);
                    PagoCln.insertar(pago);
                }
                else
                {
                    int index = dgvLista.CurrentCell.RowIndex;
                    pago.id = Convert.ToInt32(dgvLista.Rows[index].Cells["id"].Value);
                    PagoCln.actualizar(pago);
                }
                listar();
                btnCancelar.PerformClick();
                MessageBox.Show("Pago registrado correctamente", "::: Natura - Mensaje:::",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void limpiar()
        {
            cbxCitaFecha.Text = string.Empty;
            nupImporte.Value = 0;
            cbxSaldo.Text = string.Empty;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int index = dgvLista.CurrentCell.RowIndex;
            int id = Convert.ToInt32(dgvLista.Rows[index].Cells["id"].Value);

            string estado = dgvLista.Rows[index].Cells["estado"].Value.ToString();
            DialogResult dialog = MessageBox.Show($"¿Está seguro que desea eliminar el Pago {estado}?",
                "::: Natura - Mensaje :::", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialog == DialogResult.OK)
            {
                PagoCln.eliminar(id, "Edward");
                listar();
                MessageBox.Show("Pago eliminado correctamente", "::: Natura - Mensaje:::",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

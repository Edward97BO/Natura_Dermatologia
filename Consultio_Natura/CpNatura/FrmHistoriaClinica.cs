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
    public partial class FrmHistoriaClinica : Form
    {
        bool esNuevo = false;
        public FrmHistoriaClinica()
        {
            InitializeComponent();
        }
        private void listar()
        {
            var historiasClinicas = HistoriaClinicaCln.listarPa(txtParametro.Text.Trim());
            dgvLista.DataSource = historiasClinicas;
            dgvLista.Columns["id"].Visible = false;
            dgvLista.Columns["estado"].Visible = false;
            dgvLista.Columns["idPaciente"].Visible = false;
            dgvLista.Columns["idDermatologo"].Visible = false;
            dgvLista.Columns["antecedentes"].HeaderText = "Antecedentes";
            dgvLista.Columns["sintomas"].HeaderText = "Síntomas";
            dgvLista.Columns["diagnosticos"].HeaderText = "Diagnósticos";
            dgvLista.Columns["tratamientos"].HeaderText = "Tratamientos";
            dgvLista.Columns["observaciones"].HeaderText = "Observaciones";
            dgvLista.Columns["usuarioRegistro"].HeaderText = "Usuario";
            dgvLista.Columns["fechaRegistro"].HeaderText = "Fecha de Registro";
            btnEditar.Enabled = historiasClinicas.Count > 0;
            btnEliminar.Enabled = historiasClinicas.Count > 0;
            if (historiasClinicas.Count > 0) dgvLista.Rows[0].Cells["antecedentes"].Selected = true;
        }

        private void cargarPaciente()
        {
            cbxPaciente.DataSource = PacienteCln.listar();
            cbxPaciente.DisplayMember = "nombre";
            cbxPaciente.ValueMember = "id";
        }

        private void cargarDermatologo()
        {
            cbxDermatologo.DataSource = DermatologoCln.listar();
            cbxDermatologo.DisplayMember = "nombre";
            cbxDermatologo .ValueMember = "id";
        }

        private void FrmHistoriaClinica_Load(object sender, EventArgs e)
        {
            pnlDatos.Visible = false;
            listar();
            cargarPaciente();
            cargarDermatologo();
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
            var paciente = PacienteCln.get(id);
            var dermatologo = DermatologoCln.get(id);
            var historiaClinica = HistoriaClinicaCln.get(id);
            cbxPaciente.Text = paciente.nombre;
            cbxDermatologo.Text = dermatologo.nombre;
            txtAntecedentes.Text = historiaClinica.antecedentes;
            txtSintomas.Text = historiaClinica.sintomas;
            txtDiagnostico.Text = historiaClinica.diagnosticos;
            txtTratamientos.Text = historiaClinica.tratamientos;
            txtObservaciones.Text = historiaClinica.observaciones;
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
            erpDermatologo.SetError(cbxDermatologo, "");
            erpAntecedentes.SetError(txtAntecedentes, "");
            erpSintomas.SetError(txtSintomas, "");
            erpDiagnosticos.SetError(txtDiagnostico, "");
            erpTratamientos.SetError(txtTratamientos, "");
            erpObservaciones.SetError(txtObservaciones, "");
            if (string.IsNullOrEmpty(cbxPaciente.Text))
            {
                esValido = false;
                erpPaciente.SetError(cbxPaciente, "El campo Paciente es obligatorio");
            }
            if (string.IsNullOrEmpty(cbxDermatologo.Text))
            {
                esValido = false;
                erpDermatologo.SetError(cbxDermatologo, "El campo Dermatólogo es obligatorio");
            }
            if (string.IsNullOrEmpty(txtAntecedentes.Text))
            {
                esValido = false;
                erpAntecedentes.SetError(txtAntecedentes, "El campo Antecedentes del Paciente es obligatorio");
            }
            if (string.IsNullOrEmpty(txtSintomas.Text))
            {
                esValido = false;
                erpSintomas.SetError(txtSintomas, "El campo Síntomas es obligatorio");
            }
            if (string.IsNullOrEmpty(txtDiagnostico.Text))
            {
                esValido = false;
                erpDiagnosticos.SetError(txtDiagnostico, "El campo Diagnóstico es obligatorio");
            }
            if (string.IsNullOrEmpty(txtTratamientos.Text))
            {
                esValido = false;
                erpTratamientos.SetError(txtTratamientos, "El campo Tratamientos es obligatorio");
            }
            if (string.IsNullOrEmpty(txtObservaciones.Text))
            {
                esValido = false;
                erpObservaciones.SetError(txtObservaciones, "El campo Observaciones es obligatorio");
            }
            return esValido;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                var historiaClinica = new HistoriaClinica();
                historiaClinica.antecedentes = txtAntecedentes.Text.Trim();
                historiaClinica.sintomas = txtSintomas.Text.Trim();
                historiaClinica.diagnosticos = txtDiagnostico.Text.Trim();
                historiaClinica.tratamientos = txtTratamientos.Text.Trim();
                historiaClinica.observaciones = txtObservaciones.Text.Trim();
                historiaClinica.usuarioRegistro = Util.usuario.username;
                if (esNuevo)
                {
                    historiaClinica.fechaRegistro = DateTime.Now;
                    historiaClinica.estado = 1;
                    historiaClinica.idPaciente = Convert.ToInt32(cbxPaciente.SelectedValue);
                    historiaClinica.idDermatologo = Convert.ToInt32(cbxDermatologo.SelectedValue);
                    HistoriaClinicaCln.insertar(historiaClinica);
                }
                else
                {
                    int index = dgvLista.CurrentCell.RowIndex;
                    historiaClinica.id = Convert.ToInt32(dgvLista.Rows[index].Cells["id"].Value);
                    HistoriaClinicaCln.actualizar(historiaClinica);
                }
                listar();
                btnCancelar.PerformClick();
                MessageBox.Show("Historia Clínica registrada correctamente", "::: Natura - Mensaje:::",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void limpiar()
        {
            cbxPaciente.Text = string.Empty;
            cbxDermatologo.Text = string.Empty;
            txtAntecedentes.Text = string.Empty;
            txtSintomas.Text = string.Empty;
            txtDiagnostico.Text = string.Empty;
            txtTratamientos.Text = string.Empty;
            txtObservaciones.Text = string.Empty;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int index = dgvLista.CurrentCell.RowIndex;
            int id = Convert.ToInt32(dgvLista.Rows[index].Cells["id"].Value);

            string antecedentes = dgvLista.Rows[index].Cells["antecedentes"].Value.ToString();
            DialogResult dialog = MessageBox.Show("¿Está seguro que desea eliminar la Historia Clínica ?",
                "::: Natura - Mensaje :::", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialog == DialogResult.OK)
            {
                HistoriaClinicaCln.eliminar(id, "Edward");
                listar();
                MessageBox.Show("Historia Clínica eliminada correctamente", "::: Natura - Mensaje:::",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }

}

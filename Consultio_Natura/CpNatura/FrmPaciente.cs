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
    public partial class FrmPaciente : Form
    {
        bool esNuevo = true;
        public FrmPaciente()
        {
            InitializeComponent();
        }

        private void listar()
        {
            var pacientes = PacienteCln.listarPa(txtParametro.Text.Trim());
            dgvLista.DataSource = pacientes;
            dgvLista.Columns["id"].Visible = false;
            dgvLista.Columns["estado"].Visible = false;
            dgvLista.Columns["nombre"].HeaderText = "Nombres";
            dgvLista.Columns["apellido"].HeaderText = "Apellidos";
            dgvLista.Columns["ci"].HeaderText = "N° de CI";
            dgvLista.Columns["fechaNacimiento"].HeaderText = "Fecha de Nacimiento";
            dgvLista.Columns["telefono"].HeaderText = "Teléfono";
            dgvLista.Columns["email"].HeaderText = "Email";
            dgvLista.Columns["usuarioRegistro"].HeaderText = "Usuario";
            dgvLista.Columns["fechaRegistro"].HeaderText = "Fecha y Hora de Registro";
            btnEditar.Enabled = pacientes.Count > 0;
            btnEliminar.Enabled = pacientes.Count > 0;
            if (pacientes.Count > 0) dgvLista.Rows[0].Cells["nombre"].Selected = true;
        }

        private void FrmPaciente_Load(object sender, EventArgs e)
        {
            pnlDatos.Visible = false;
            listar();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            esNuevo = true;
            pnlDatos.Visible = true;
            txtNombre.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            esNuevo = false;
            pnlDatos.Visible = true;

            int index = dgvLista.CurrentCell.RowIndex;
            int id = Convert.ToInt32(dgvLista.Rows[index].Cells["id"].Value);
            var paciente = PacienteCln.get(id);
            txtNombre.Text = paciente.nombre;
            txtApellido.Text = paciente.apellido;
            txtCi.Text = paciente.ci;
            dtpFechaNacimiento.Value = paciente.fechaNacimiento;
            txtTelefono.Text = paciente.telefono;
            txtEmail.Text= paciente.email;
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
            erpNombre.SetError(txtNombre, "");
            erpApellido.SetError(txtApellido, "");
            erpCi.SetError(txtCi, "");
            erpTelefono.SetError(txtTelefono, "");
            erpEmail.SetError(txtEmail, "");
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                esValido = false;
                erpNombre.SetError(txtNombre, "El campo Nombres es obligatorio");
            }
            if (string.IsNullOrEmpty(txtApellido.Text))
            {
                esValido = false;
                erpApellido.SetError(txtApellido, "El campo Apellidos es obligatorio");
            }
            if (string.IsNullOrEmpty(txtCi.Text))
            {
                esValido = false;
                erpCi.SetError(txtCi, "El campo CI es obligatorio");
            }
            if (string.IsNullOrEmpty(txtTelefono.Text))
            {
                esValido = false;
                erpTelefono.SetError(txtTelefono, "El campo Teléfono es obligatorio");
            }
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                esValido = false;
                erpEmail.SetError(txtEmail, "El campo Email es obligatorio");
            }
            return esValido;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                var paciente = new Paciente();
                paciente.nombre = txtNombre.Text.Trim();
                paciente.apellido = txtApellido.Text.Trim();
                paciente.ci =   txtCi.Text.Trim();
                paciente.fechaNacimiento = dtpFechaNacimiento.Value;
                paciente.telefono = txtTelefono.Text.Trim();
                paciente.email = txtEmail.Text.Trim();
                paciente.usuarioRegistro = "Edward";
                if (esNuevo)
                {
                    paciente.fechaRegistro = DateTime.Now;
                    paciente.estado = 1;
                    PacienteCln.insertar(paciente);
                }
                else
                {
                    int index = dgvLista.CurrentCell.RowIndex;
                    paciente.id = Convert.ToInt32(dgvLista.Rows[index].Cells["id"].Value);
                    PacienteCln.actualizar(paciente);
                }
                listar();
                btnCancelar.PerformClick();
                MessageBox.Show("Paciente registrado correctamente", "::: Natura - Mensaje:::",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void limpiar()
        {
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            txtCi.Text = string.Empty;
            dtpFechaNacimiento.Value = DateTime.Now;
            txtTelefono.Text = string.Empty;
            txtEmail.Text = string.Empty;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int index = dgvLista.CurrentCell.RowIndex;
            int id = Convert.ToInt32(dgvLista.Rows[index].Cells["id"].Value);

            string nombre = dgvLista.Rows[index].Cells["nombre"].Value.ToString();
            DialogResult dialog = MessageBox.Show($"¿Está seguro que desea eliminar el Paciente {nombre}?",
                "::: Natura - Mensaje :::", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialog == DialogResult.OK)
            {
                PacienteCln.eliminar(id, "Edward");
                listar();
                MessageBox.Show("Paciente eliminado correctamente", "::: Natura - Mensaje:::",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

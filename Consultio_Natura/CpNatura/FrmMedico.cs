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
    public partial class FrmMedico : Form
    {
        bool esNuevo = false;

        public FrmMedico()
        {
            InitializeComponent();
        }
        private void listar()
        {
            var dermatologos = DermatologoCln.listarPa(txtParametro.Text.Trim());
            dgvLista.DataSource = dermatologos;
            dgvLista.Columns["id"].Visible = false;
            dgvLista.Columns["estado"].Visible = false;
            dgvLista.Columns["nombre"].HeaderText = "Nombres";
            dgvLista.Columns["apellido"].HeaderText = "Apellidos";
            dgvLista.Columns["matricula"].HeaderText = "Matrícula";
            dgvLista.Columns["especialidad"].HeaderText = "Especialidad";
            dgvLista.Columns["usuarioRegistro"].HeaderText = "Usuario";
            dgvLista.Columns["fechaRegistro"].HeaderText = "Fecha de Registro";
            btnEditar.Enabled = dermatologos.Count > 0;
            btnEliminar.Enabled = dermatologos.Count > 0;
            if (dermatologos.Count > 0) dgvLista.Rows[0].Cells["nombre"].Selected = true;
        }

        private void FrmMedico_Load(object sender, EventArgs e)
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
            var dermatologo = DermatologoCln.get(id);
            txtNombre.Text = dermatologo.nombre;
            txtApellido.Text = dermatologo.apellido;
            txtMatricula.Text = dermatologo.matricula;
            txtEspecialidad.Text = dermatologo.especialidad;
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
            erpMatricula.SetError(txtMatricula, "");
            erpEspecialidad.SetError(txtEspecialidad, "");
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
            if (string.IsNullOrEmpty(txtMatricula.Text))
            {
                esValido = false;
                erpMatricula.SetError(txtMatricula, "El campo Matrícula es obligatorio");
            }
            if (string.IsNullOrEmpty(txtEspecialidad.Text))
            {
                esValido = false;
                erpEspecialidad.SetError(txtEspecialidad, "El campo Código es obligatorio");
            }
            return esValido;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                var dermatologo = new Dermatologo();
                dermatologo.nombre = txtNombre.Text.Trim();
                dermatologo.apellido = txtApellido.Text.Trim(); 
                dermatologo.matricula = txtMatricula.Text.Trim();
                dermatologo.especialidad = txtEspecialidad.Text.Trim();
                dermatologo.usuarioRegistro = "Edward";
                if (esNuevo)
                {
                    dermatologo.fechaRegistro = DateTime.Now;
                    dermatologo.estado = 1;
                    DermatologoCln.insertar(dermatologo);
                }
                else
                {
                    int index = dgvLista.CurrentCell.RowIndex;
                    dermatologo.id = Convert.ToInt32(dgvLista.Rows[index].Cells["id"].Value);
                    DermatologoCln.actualizar(dermatologo);
                }
                listar();
                btnCancelar.PerformClick();
                MessageBox.Show("Médico registrado correctamente", "::: Natura - Mensaje:::",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void limpiar()
        {
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            txtMatricula.Text = string.Empty;
            txtEspecialidad.Text = string.Empty;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int index = dgvLista.CurrentCell.RowIndex;
            int id = Convert.ToInt32(dgvLista.Rows[index].Cells["id"].Value);

            string nombre = dgvLista.Rows[index].Cells["nombre"].Value.ToString();
            DialogResult dialog = MessageBox.Show($"¿Está seguro que desea eliminar el Médico {nombre}?",
                "::: Natura - Mensaje :::", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialog == DialogResult.OK)
            {
                DermatologoCln.eliminar(id, "Edward");
                listar();
                MessageBox.Show("Médico eliminado correctamente", "::: Natura - Mensaje:::",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

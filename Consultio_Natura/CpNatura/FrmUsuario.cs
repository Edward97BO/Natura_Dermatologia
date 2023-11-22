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
    public partial class FrmUsuario : Form
    {
        bool esNuevo = false;
        public FrmUsuario()
        {
            InitializeComponent();
        }
        private void listar()
        {
            var usuarios = UsuarioCln.listarPa(txtParametro.Text.Trim());
            dgvLista.DataSource = usuarios;
            dgvLista.Columns["id"].Visible = false;
            dgvLista.Columns["estado"].Visible = false;
            dgvLista.Columns["nombre"].HeaderText = "Nombres";
            dgvLista.Columns["apellido"].HeaderText = "Apellidos";
            dgvLista.Columns["username"].HeaderText = "Usuario";
            dgvLista.Columns["password"].HeaderText = "Contraseña";
            dgvLista.Columns["rol"].HeaderText = "Rol";
            dgvLista.Columns["usuarioRegistro"].HeaderText = "Usuario";
            dgvLista.Columns["fechaRegistro"].HeaderText = "Fecha y Hora de Registro";
            btnEditar.Enabled = usuarios.Count > 0;
            btnEliminar.Enabled = usuarios.Count > 0;
            if (usuarios.Count > 0) dgvLista.Rows[0].Cells["nombre"].Selected = true;
        }

        private void FrmUsuario_Load(object sender, EventArgs e)
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
            var usuario = UsuarioCln.get(id);
            txtNombre.Text = usuario.nombre;
            txtApellido.Text = usuario.apellido;
            txtUsuario.Text = usuario.username;
            txtPassword.Text = usuario.password;
            cbxRol.Text = usuario.rol;
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
            erpUsuario.SetError(txtUsuario, "");
            erpPassword.SetError(txtPassword, "");
            erpRol.SetError(cbxRol, "");
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
            if (string.IsNullOrEmpty(txtUsuario.Text))
            {
                esValido = false;
                erpUsuario.SetError(txtUsuario, "El campo Usuario es obligatorio");
            }
            if (string.IsNullOrEmpty(txtUsuario.Text))
            {
                esValido = false;
                erpPassword.SetError(txtPassword, "El campo Contraseña es obligatorio");
            }
            if (string.IsNullOrEmpty(cbxRol.Text))
            {
                esValido = false;
                erpRol.SetError(cbxRol, "El campo Rol es obligatorio");
            }
            return esValido;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                var usuario = new Usuario();
                usuario.nombre = txtNombre.Text.Trim();
                usuario.apellido = txtApellido.Text.Trim();
                usuario.username = txtUsuario.Text.Trim();
                usuario.password = Util.Encrypt(txtPassword.Text.Trim());
                usuario.rol = cbxRol.Text.Trim();
                usuario.usuarioRegistro = Util.usuario.username;
                if (esNuevo)
                {
                    usuario.fechaRegistro = DateTime.Now;
                    usuario.estado = 1;
                    UsuarioCln.insertar(usuario);
                }
                else
                {
                    int index = dgvLista.CurrentCell.RowIndex;
                    usuario.id = Convert.ToInt32(dgvLista.Rows[index].Cells["id"].Value);
                    UsuarioCln.actualizar(usuario);
                }
                listar();
                btnCancelar.PerformClick();
                MessageBox.Show("Usuario guardado correctamente", "::: Natura - Mensaje:::",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void limpiar()
        {
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            txtUsuario.Text = string.Empty;
            txtPassword.Text = string.Empty;
            cbxRol.Text = string.Empty;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int index = dgvLista.CurrentCell.RowIndex;
            int id = Convert.ToInt32(dgvLista.Rows[index].Cells["id"].Value);

            string nombre = dgvLista.Rows[index].Cells["nombre"].Value.ToString();
            DialogResult dialog = MessageBox.Show($"¿Está seguro que desea eliminar el Usuario {nombre}?",
                "::: Natura - Mensaje :::", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialog == DialogResult.OK)
            {
                UsuarioCln.eliminar(id, "Edward");
                listar();
                MessageBox.Show("Usuario eliminado correctamente", "::: Natura - Mensaje:::",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

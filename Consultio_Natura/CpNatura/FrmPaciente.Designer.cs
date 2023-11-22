namespace CpNatura
{
    partial class FrmPaciente
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
            this.components = new System.ComponentModel.Container();
            this.pnlDatos = new System.Windows.Forms.Panel();
            this.gbxDatos = new System.Windows.Forms.GroupBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.txtCi = new System.Windows.Forms.TextBox();
            this.lblCi = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblBusqueda = new System.Windows.Forms.Label();
            this.txtParametro = new System.Windows.Forms.TextBox();
            this.gbxLista = new System.Windows.Forms.GroupBox();
            this.dgvLista = new System.Windows.Forms.DataGridView();
            this.pnlAcciones = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.erpNombre = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpApellido = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpCi = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpTelefono = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpEmail = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblAutor = new System.Windows.Forms.Label();
            this.pnlDatos.SuspendLayout();
            this.gbxDatos.SuspendLayout();
            this.gbxLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            this.pnlAcciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpNombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpApellido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpCi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpTelefono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpEmail)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDatos
            // 
            this.pnlDatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(120)))), ((int)(((byte)(104)))));
            this.pnlDatos.Controls.Add(this.gbxDatos);
            this.pnlDatos.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlDatos.Location = new System.Drawing.Point(775, 0);
            this.pnlDatos.Name = "pnlDatos";
            this.pnlDatos.Size = new System.Drawing.Size(305, 615);
            this.pnlDatos.TabIndex = 1;
            // 
            // gbxDatos
            // 
            this.gbxDatos.Controls.Add(this.txtEmail);
            this.gbxDatos.Controls.Add(this.label2);
            this.gbxDatos.Controls.Add(this.txtTelefono);
            this.gbxDatos.Controls.Add(this.lblTelefono);
            this.gbxDatos.Controls.Add(this.dtpFechaNacimiento);
            this.gbxDatos.Controls.Add(this.btnCancelar);
            this.gbxDatos.Controls.Add(this.btnGuardar);
            this.gbxDatos.Controls.Add(this.lblFechaNacimiento);
            this.gbxDatos.Controls.Add(this.txtCi);
            this.gbxDatos.Controls.Add(this.lblCi);
            this.gbxDatos.Controls.Add(this.txtApellido);
            this.gbxDatos.Controls.Add(this.lblApellido);
            this.gbxDatos.Controls.Add(this.txtNombre);
            this.gbxDatos.Controls.Add(this.lblNombre);
            this.gbxDatos.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxDatos.ForeColor = System.Drawing.SystemColors.Control;
            this.gbxDatos.Location = new System.Drawing.Point(17, 13);
            this.gbxDatos.Name = "gbxDatos";
            this.gbxDatos.Size = new System.Drawing.Size(276, 590);
            this.gbxDatos.TabIndex = 0;
            this.gbxDatos.TabStop = false;
            this.gbxDatos.Text = "Datos del Paciente";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(22, 336);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(233, 29);
            this.txtEmail.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 311);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 22);
            this.label2.TabIndex = 16;
            this.label2.Text = "Email:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(22, 279);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(233, 29);
            this.txtTelefono.TabIndex = 15;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(18, 254);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(94, 22);
            this.lblTelefono.TabIndex = 14;
            this.lblTelefono.Text = "Teléfono:";
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(230)))), ((int)(((byte)(211)))));
            this.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(81, 224);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(143, 29);
            this.dtpFechaNacimiento.TabIndex = 13;
            this.dtpFechaNacimiento.TabStop = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(237)))), ((int)(((byte)(229)))));
            this.btnCancelar.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.Teal;
            this.btnCancelar.Image = global::CpNatura.Properties.Resources.Cancelar;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(81, 476);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(143, 70);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(237)))), ((int)(((byte)(229)))));
            this.btnGuardar.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.Teal;
            this.btnGuardar.Image = global::CpNatura.Properties.Resources.Guardar;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(81, 400);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(143, 70);
            this.btnGuardar.TabIndex = 11;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Location = new System.Drawing.Point(18, 199);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(207, 22);
            this.lblFechaNacimiento.TabIndex = 6;
            this.lblFechaNacimiento.Text = "Fecha de Nacimiento:";
            // 
            // txtCi
            // 
            this.txtCi.Location = new System.Drawing.Point(22, 167);
            this.txtCi.Name = "txtCi";
            this.txtCi.Size = new System.Drawing.Size(233, 29);
            this.txtCi.TabIndex = 5;
            // 
            // lblCi
            // 
            this.lblCi.AutoSize = true;
            this.lblCi.Location = new System.Drawing.Point(18, 142);
            this.lblCi.Name = "lblCi";
            this.lblCi.Size = new System.Drawing.Size(36, 22);
            this.lblCi.TabIndex = 4;
            this.lblCi.Text = "CI:";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(22, 110);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(233, 29);
            this.txtApellido.TabIndex = 3;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(18, 82);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(101, 22);
            this.lblApellido.TabIndex = 2;
            this.lblApellido.Text = "Apellidos:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(22, 50);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(233, 29);
            this.txtNombre.TabIndex = 1;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(18, 25);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(99, 22);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombres:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Cooper Black", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(230)))), ((int)(((byte)(211)))));
            this.lblTitulo.Location = new System.Drawing.Point(3, 36);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(766, 46);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "PACIENTES";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblBusqueda
            // 
            this.lblBusqueda.AutoSize = true;
            this.lblBusqueda.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusqueda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(237)))), ((int)(((byte)(229)))));
            this.lblBusqueda.Location = new System.Drawing.Point(77, 123);
            this.lblBusqueda.Name = "lblBusqueda";
            this.lblBusqueda.Size = new System.Drawing.Size(316, 21);
            this.lblBusqueda.TabIndex = 3;
            this.lblBusqueda.Text = "Buscar por nombre de paciente:";
            // 
            // txtParametro
            // 
            this.txtParametro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(237)))), ((int)(((byte)(229)))));
            this.txtParametro.Location = new System.Drawing.Point(81, 166);
            this.txtParametro.Name = "txtParametro";
            this.txtParametro.Size = new System.Drawing.Size(444, 20);
            this.txtParametro.TabIndex = 4;
            this.txtParametro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtParametro_KeyPress);
            // 
            // gbxLista
            // 
            this.gbxLista.Controls.Add(this.dgvLista);
            this.gbxLista.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxLista.Location = new System.Drawing.Point(76, 211);
            this.gbxLista.Name = "gbxLista";
            this.gbxLista.Size = new System.Drawing.Size(595, 188);
            this.gbxLista.TabIndex = 6;
            this.gbxLista.TabStop = false;
            this.gbxLista.Text = "Lista de Pacientes:";
            // 
            // dgvLista
            // 
            this.dgvLista.AllowUserToAddRows = false;
            this.dgvLista.AllowUserToDeleteRows = false;
            this.dgvLista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvLista.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(230)))), ((int)(((byte)(211)))));
            this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLista.Location = new System.Drawing.Point(17, 26);
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.ReadOnly = true;
            this.dgvLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLista.Size = new System.Drawing.Size(560, 150);
            this.dgvLista.TabIndex = 0;
            // 
            // pnlAcciones
            // 
            this.pnlAcciones.Controls.Add(this.btnCerrar);
            this.pnlAcciones.Controls.Add(this.btnEliminar);
            this.pnlAcciones.Controls.Add(this.btnEditar);
            this.pnlAcciones.Controls.Add(this.btnNuevo);
            this.pnlAcciones.Location = new System.Drawing.Point(76, 431);
            this.pnlAcciones.Name = "pnlAcciones";
            this.pnlAcciones.Size = new System.Drawing.Size(595, 94);
            this.pnlAcciones.TabIndex = 7;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(237)))), ((int)(((byte)(229)))));
            this.btnCerrar.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.Teal;
            this.btnCerrar.Image = global::CpNatura.Properties.Resources.Cerrar;
            this.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrar.Location = new System.Drawing.Point(453, 9);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(124, 70);
            this.btnCerrar.TabIndex = 10;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(237)))), ((int)(((byte)(229)))));
            this.btnEliminar.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.Teal;
            this.btnEliminar.Image = global::CpNatura.Properties.Resources.Eliminar;
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(295, 9);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(140, 70);
            this.btnEliminar.TabIndex = 9;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(237)))), ((int)(((byte)(229)))));
            this.btnEditar.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.Teal;
            this.btnEditar.Image = global::CpNatura.Properties.Resources.Editar;
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(160, 9);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(119, 70);
            this.btnEditar.TabIndex = 8;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(237)))), ((int)(((byte)(229)))));
            this.btnNuevo.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.Color.Teal;
            this.btnNuevo.Image = global::CpNatura.Properties.Resources.Nuevo;
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.Location = new System.Drawing.Point(17, 9);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(119, 70);
            this.btnNuevo.TabIndex = 7;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // erpNombre
            // 
            this.erpNombre.ContainerControl = this;
            // 
            // erpApellido
            // 
            this.erpApellido.ContainerControl = this;
            // 
            // erpCi
            // 
            this.erpCi.ContainerControl = this;
            // 
            // erpTelefono
            // 
            this.erpTelefono.ContainerControl = this;
            // 
            // erpEmail
            // 
            this.erpEmail.ContainerControl = this;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(237)))), ((int)(((byte)(229)))));
            this.btnBuscar.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.Teal;
            this.btnBuscar.Image = global::CpNatura.Properties.Resources.Busca;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(553, 131);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(118, 55);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(237)))), ((int)(((byte)(229)))));
            this.lblAutor.Location = new System.Drawing.Point(282, 568);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(180, 22);
            this.lblAutor.TabIndex = 13;
            this.lblAutor.Text = "By Edward Barrera";
            // 
            // FrmPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(156)))), ((int)(((byte)(137)))));
            this.ClientSize = new System.Drawing.Size(1080, 615);
            this.Controls.Add(this.lblAutor);
            this.Controls.Add(this.pnlAcciones);
            this.Controls.Add(this.gbxLista);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtParametro);
            this.Controls.Add(this.lblBusqueda);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pnlDatos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPaciente";
            this.Text = "FrmPaciente";
            this.Load += new System.EventHandler(this.FrmPaciente_Load);
            this.pnlDatos.ResumeLayout(false);
            this.gbxDatos.ResumeLayout(false);
            this.gbxDatos.PerformLayout();
            this.gbxLista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            this.pnlAcciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.erpNombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpApellido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpCi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpTelefono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpEmail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlDatos;
        private System.Windows.Forms.GroupBox gbxDatos;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.TextBox txtCi;
        private System.Windows.Forms.Label lblCi;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblBusqueda;
        private System.Windows.Forms.TextBox txtParametro;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.GroupBox gbxLista;
        private System.Windows.Forms.DataGridView dgvLista;
        private System.Windows.Forms.Panel pnlAcciones;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.ErrorProvider erpNombre;
        private System.Windows.Forms.ErrorProvider erpApellido;
        private System.Windows.Forms.ErrorProvider erpCi;
        private System.Windows.Forms.ErrorProvider erpTelefono;
        private System.Windows.Forms.ErrorProvider erpEmail;
        private System.Windows.Forms.Label lblAutor;
    }
}
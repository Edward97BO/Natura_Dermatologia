namespace CpNatura
{
    partial class FrmCita
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
            this.dtpHora = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxPaciente = new System.Windows.Forms.ComboBox();
            this.txtMotivo = new System.Windows.Forms.TextBox();
            this.lblMotivo = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblFechaConsulta = new System.Windows.Forms.Label();
            this.lblPaciente = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblBusqueda = new System.Windows.Forms.Label();
            this.txtParametro = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.gbxLista = new System.Windows.Forms.GroupBox();
            this.dgvLista = new System.Windows.Forms.DataGridView();
            this.pnlAcciones = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.erpPaciente = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpMotivo = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblAutor = new System.Windows.Forms.Label();
            this.pnlDatos.SuspendLayout();
            this.gbxDatos.SuspendLayout();
            this.gbxLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            this.pnlAcciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpPaciente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpMotivo)).BeginInit();
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
            this.pnlDatos.TabIndex = 2;
            // 
            // gbxDatos
            // 
            this.gbxDatos.Controls.Add(this.dtpHora);
            this.gbxDatos.Controls.Add(this.label1);
            this.gbxDatos.Controls.Add(this.cbxPaciente);
            this.gbxDatos.Controls.Add(this.txtMotivo);
            this.gbxDatos.Controls.Add(this.lblMotivo);
            this.gbxDatos.Controls.Add(this.dtpFecha);
            this.gbxDatos.Controls.Add(this.btnCancelar);
            this.gbxDatos.Controls.Add(this.btnGuardar);
            this.gbxDatos.Controls.Add(this.lblFechaConsulta);
            this.gbxDatos.Controls.Add(this.lblPaciente);
            this.gbxDatos.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxDatos.ForeColor = System.Drawing.SystemColors.Control;
            this.gbxDatos.Location = new System.Drawing.Point(17, 13);
            this.gbxDatos.Name = "gbxDatos";
            this.gbxDatos.Size = new System.Drawing.Size(276, 590);
            this.gbxDatos.TabIndex = 0;
            this.gbxDatos.TabStop = false;
            this.gbxDatos.Text = "Datos de la Cita:";
            // 
            // dtpHora
            // 
            this.dtpHora.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(230)))), ((int)(((byte)(211)))));
            this.dtpHora.CustomFormat = "H : mm";
            this.dtpHora.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHora.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtpHora.Location = new System.Drawing.Point(22, 181);
            this.dtpHora.Name = "dtpHora";
            this.dtpHora.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtpHora.ShowUpDown = true;
            this.dtpHora.Size = new System.Drawing.Size(87, 29);
            this.dtpHora.TabIndex = 20;
            this.dtpHora.TabStop = false;
            this.dtpHora.Value = new System.DateTime(2023, 11, 21, 21, 35, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 22);
            this.label1.TabIndex = 19;
            this.label1.Text = "Hora:";
            // 
            // cbxPaciente
            // 
            this.cbxPaciente.FormattingEnabled = true;
            this.cbxPaciente.Location = new System.Drawing.Point(22, 49);
            this.cbxPaciente.Name = "cbxPaciente";
            this.cbxPaciente.Size = new System.Drawing.Size(233, 30);
            this.cbxPaciente.TabIndex = 18;
            // 
            // txtMotivo
            // 
            this.txtMotivo.Location = new System.Drawing.Point(22, 250);
            this.txtMotivo.Multiline = true;
            this.txtMotivo.Name = "txtMotivo";
            this.txtMotivo.Size = new System.Drawing.Size(233, 125);
            this.txtMotivo.TabIndex = 15;
            // 
            // lblMotivo
            // 
            this.lblMotivo.AutoSize = true;
            this.lblMotivo.Location = new System.Drawing.Point(18, 225);
            this.lblMotivo.Name = "lblMotivo";
            this.lblMotivo.Size = new System.Drawing.Size(70, 22);
            this.lblMotivo.TabIndex = 14;
            this.lblMotivo.Text = "Motivo";
            // 
            // dtpFecha
            // 
            this.dtpFecha.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(230)))), ((int)(((byte)(211)))));
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(22, 121);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(143, 29);
            this.dtpFecha.TabIndex = 13;
            this.dtpFecha.TabStop = false;
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
            // lblFechaConsulta
            // 
            this.lblFechaConsulta.AutoSize = true;
            this.lblFechaConsulta.Location = new System.Drawing.Point(18, 92);
            this.lblFechaConsulta.Name = "lblFechaConsulta";
            this.lblFechaConsulta.Size = new System.Drawing.Size(212, 22);
            this.lblFechaConsulta.TabIndex = 6;
            this.lblFechaConsulta.Text = "Fecha de de Consulta:";
            // 
            // lblPaciente
            // 
            this.lblPaciente.AutoSize = true;
            this.lblPaciente.Location = new System.Drawing.Point(18, 25);
            this.lblPaciente.Name = "lblPaciente";
            this.lblPaciente.Size = new System.Drawing.Size(217, 22);
            this.lblPaciente.TabIndex = 0;
            this.lblPaciente.Text = "Nombres del Paciente:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Cooper Black", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(230)))), ((int)(((byte)(211)))));
            this.lblTitulo.Location = new System.Drawing.Point(4, 38);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(766, 46);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "CONSULTAS";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblBusqueda
            // 
            this.lblBusqueda.AutoSize = true;
            this.lblBusqueda.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusqueda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(237)))), ((int)(((byte)(229)))));
            this.lblBusqueda.Location = new System.Drawing.Point(81, 134);
            this.lblBusqueda.Name = "lblBusqueda";
            this.lblBusqueda.Size = new System.Drawing.Size(298, 21);
            this.lblBusqueda.TabIndex = 4;
            this.lblBusqueda.Text = "Buscar por fecha de Consulta:";
            // 
            // txtParametro
            // 
            this.txtParametro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(237)))), ((int)(((byte)(229)))));
            this.txtParametro.Location = new System.Drawing.Point(85, 169);
            this.txtParametro.Name = "txtParametro";
            this.txtParametro.Size = new System.Drawing.Size(444, 20);
            this.txtParametro.TabIndex = 5;
            this.txtParametro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtParametro_KeyPress);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(237)))), ((int)(((byte)(229)))));
            this.btnBuscar.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.Teal;
            this.btnBuscar.Image = global::CpNatura.Properties.Resources.Busca;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(554, 134);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(118, 55);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // gbxLista
            // 
            this.gbxLista.Controls.Add(this.dgvLista);
            this.gbxLista.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxLista.Location = new System.Drawing.Point(85, 212);
            this.gbxLista.Name = "gbxLista";
            this.gbxLista.Size = new System.Drawing.Size(595, 188);
            this.gbxLista.TabIndex = 7;
            this.gbxLista.TabStop = false;
            this.gbxLista.Text = "Lista de Citas";
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
            this.pnlAcciones.Location = new System.Drawing.Point(85, 435);
            this.pnlAcciones.Name = "pnlAcciones";
            this.pnlAcciones.Size = new System.Drawing.Size(595, 94);
            this.pnlAcciones.TabIndex = 8;
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
            // erpPaciente
            // 
            this.erpPaciente.ContainerControl = this;
            // 
            // erpMotivo
            // 
            this.erpMotivo.ContainerControl = this;
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(237)))), ((int)(((byte)(229)))));
            this.lblAutor.Location = new System.Drawing.Point(289, 571);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(180, 22);
            this.lblAutor.TabIndex = 9;
            this.lblAutor.Text = "By Edward Barrera";
            // 
            // FrmCita
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
            this.Name = "FrmCita";
            this.Text = "FrmCita";
            this.Load += new System.EventHandler(this.FrmCita_Load);
            this.pnlDatos.ResumeLayout(false);
            this.gbxDatos.ResumeLayout(false);
            this.gbxDatos.PerformLayout();
            this.gbxLista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            this.pnlAcciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.erpPaciente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpMotivo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlDatos;
        private System.Windows.Forms.GroupBox gbxDatos;
        private System.Windows.Forms.TextBox txtMotivo;
        private System.Windows.Forms.Label lblMotivo;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblFechaConsulta;
        private System.Windows.Forms.Label lblPaciente;
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxPaciente;
        private System.Windows.Forms.DateTimePicker dtpHora;
        private System.Windows.Forms.ErrorProvider erpPaciente;
        private System.Windows.Forms.ErrorProvider erpMotivo;
        private System.Windows.Forms.Label lblAutor;
    }
}
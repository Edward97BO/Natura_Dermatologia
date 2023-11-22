namespace CpNatura
{
    partial class FrmReconsulta
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
            this.txtMotivo = new System.Windows.Forms.TextBox();
            this.lblMotivo = new System.Windows.Forms.Label();
            this.dtpHora = new System.Windows.Forms.DateTimePicker();
            this.lblHora = new System.Windows.Forms.Label();
            this.cbxMotivo = new System.Windows.Forms.ComboBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblFechaReconsulta = new System.Windows.Forms.Label();
            this.lblMotivoConsulta = new System.Windows.Forms.Label();
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
            this.erpCita = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpMotivo = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblAutor = new System.Windows.Forms.Label();
            this.pnlDatos.SuspendLayout();
            this.gbxDatos.SuspendLayout();
            this.gbxLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            this.pnlAcciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpCita)).BeginInit();
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
            this.pnlDatos.TabIndex = 3;
            // 
            // gbxDatos
            // 
            this.gbxDatos.Controls.Add(this.txtMotivo);
            this.gbxDatos.Controls.Add(this.lblMotivo);
            this.gbxDatos.Controls.Add(this.dtpHora);
            this.gbxDatos.Controls.Add(this.lblHora);
            this.gbxDatos.Controls.Add(this.cbxMotivo);
            this.gbxDatos.Controls.Add(this.dtpFecha);
            this.gbxDatos.Controls.Add(this.btnCancelar);
            this.gbxDatos.Controls.Add(this.btnGuardar);
            this.gbxDatos.Controls.Add(this.lblFechaReconsulta);
            this.gbxDatos.Controls.Add(this.lblMotivoConsulta);
            this.gbxDatos.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxDatos.ForeColor = System.Drawing.SystemColors.Control;
            this.gbxDatos.Location = new System.Drawing.Point(17, 13);
            this.gbxDatos.Name = "gbxDatos";
            this.gbxDatos.Size = new System.Drawing.Size(276, 590);
            this.gbxDatos.TabIndex = 0;
            this.gbxDatos.TabStop = false;
            this.gbxDatos.Text = "Datos de la reconsulta:";
            // 
            // txtMotivo
            // 
            this.txtMotivo.Location = new System.Drawing.Point(22, 279);
            this.txtMotivo.Multiline = true;
            this.txtMotivo.Name = "txtMotivo";
            this.txtMotivo.Size = new System.Drawing.Size(230, 157);
            this.txtMotivo.TabIndex = 24;
            // 
            // lblMotivo
            // 
            this.lblMotivo.AutoSize = true;
            this.lblMotivo.Location = new System.Drawing.Point(18, 253);
            this.lblMotivo.Name = "lblMotivo";
            this.lblMotivo.Size = new System.Drawing.Size(211, 22);
            this.lblMotivo.TabIndex = 23;
            this.lblMotivo.Text = "Motivo de Reconsulta:";
            // 
            // dtpHora
            // 
            this.dtpHora.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(230)))), ((int)(((byte)(211)))));
            this.dtpHora.CustomFormat = "H : mm";
            this.dtpHora.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHora.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtpHora.Location = new System.Drawing.Point(22, 208);
            this.dtpHora.Name = "dtpHora";
            this.dtpHora.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtpHora.ShowUpDown = true;
            this.dtpHora.Size = new System.Drawing.Size(87, 29);
            this.dtpHora.TabIndex = 20;
            this.dtpHora.TabStop = false;
            this.dtpHora.Value = new System.DateTime(2023, 11, 21, 21, 35, 0, 0);
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(18, 183);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(60, 22);
            this.lblHora.TabIndex = 19;
            this.lblHora.Text = "Hora:";
            // 
            // cbxMotivo
            // 
            this.cbxMotivo.FormattingEnabled = true;
            this.cbxMotivo.Location = new System.Drawing.Point(22, 76);
            this.cbxMotivo.Name = "cbxMotivo";
            this.cbxMotivo.Size = new System.Drawing.Size(233, 30);
            this.cbxMotivo.TabIndex = 18;
            // 
            // dtpFecha
            // 
            this.dtpFecha.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(230)))), ((int)(((byte)(211)))));
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(22, 148);
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
            this.btnCancelar.Location = new System.Drawing.Point(146, 499);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(84, 70);
            this.btnCancelar.TabIndex = 12;
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
            this.btnGuardar.Location = new System.Drawing.Point(40, 499);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(83, 70);
            this.btnGuardar.TabIndex = 11;
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblFechaReconsulta
            // 
            this.lblFechaReconsulta.AutoSize = true;
            this.lblFechaReconsulta.Location = new System.Drawing.Point(18, 119);
            this.lblFechaReconsulta.Name = "lblFechaReconsulta";
            this.lblFechaReconsulta.Size = new System.Drawing.Size(234, 22);
            this.lblFechaReconsulta.TabIndex = 6;
            this.lblFechaReconsulta.Text = "Fecha de de Reconsulta:";
            // 
            // lblMotivoConsulta
            // 
            this.lblMotivoConsulta.AutoSize = true;
            this.lblMotivoConsulta.Location = new System.Drawing.Point(18, 52);
            this.lblMotivoConsulta.Name = "lblMotivoConsulta";
            this.lblMotivoConsulta.Size = new System.Drawing.Size(189, 22);
            this.lblMotivoConsulta.TabIndex = 0;
            this.lblMotivoConsulta.Text = "Motivo de Consulta:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Cooper Black", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(230)))), ((int)(((byte)(211)))));
            this.lblTitulo.Location = new System.Drawing.Point(3, 46);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(766, 46);
            this.lblTitulo.TabIndex = 4;
            this.lblTitulo.Text = "RECONSULTAS";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblBusqueda
            // 
            this.lblBusqueda.AutoSize = true;
            this.lblBusqueda.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusqueda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(237)))), ((int)(((byte)(229)))));
            this.lblBusqueda.Location = new System.Drawing.Point(85, 134);
            this.lblBusqueda.Name = "lblBusqueda";
            this.lblBusqueda.Size = new System.Drawing.Size(335, 21);
            this.lblBusqueda.TabIndex = 5;
            this.lblBusqueda.Text = "Buscar por motivo de Reconsulta:";
            // 
            // txtParametro
            // 
            this.txtParametro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(237)))), ((int)(((byte)(229)))));
            this.txtParametro.Location = new System.Drawing.Point(89, 173);
            this.txtParametro.Name = "txtParametro";
            this.txtParametro.Size = new System.Drawing.Size(444, 20);
            this.txtParametro.TabIndex = 6;
            this.txtParametro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtParametro_KeyPress);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(237)))), ((int)(((byte)(229)))));
            this.btnBuscar.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.Teal;
            this.btnBuscar.Image = global::CpNatura.Properties.Resources.Busca;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(560, 138);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(118, 55);
            this.btnBuscar.TabIndex = 7;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // gbxLista
            // 
            this.gbxLista.Controls.Add(this.dgvLista);
            this.gbxLista.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxLista.Location = new System.Drawing.Point(89, 219);
            this.gbxLista.Name = "gbxLista";
            this.gbxLista.Size = new System.Drawing.Size(595, 188);
            this.gbxLista.TabIndex = 8;
            this.gbxLista.TabStop = false;
            this.gbxLista.Text = "Lista de Reconsultas:";
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
            this.pnlAcciones.Location = new System.Drawing.Point(89, 431);
            this.pnlAcciones.Name = "pnlAcciones";
            this.pnlAcciones.Size = new System.Drawing.Size(595, 94);
            this.pnlAcciones.TabIndex = 9;
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
            // erpCita
            // 
            this.erpCita.ContainerControl = this;
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
            this.lblAutor.Location = new System.Drawing.Point(290, 560);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(180, 22);
            this.lblAutor.TabIndex = 14;
            this.lblAutor.Text = "By Edward Barrera";
            // 
            // FrmReconsulta
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
            this.Name = "FrmReconsulta";
            this.Text = "FrmReconsulta";
            this.Load += new System.EventHandler(this.FrmReconsulta_Load);
            this.pnlDatos.ResumeLayout(false);
            this.gbxDatos.ResumeLayout(false);
            this.gbxDatos.PerformLayout();
            this.gbxLista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            this.pnlAcciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.erpCita)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpMotivo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlDatos;
        private System.Windows.Forms.GroupBox gbxDatos;
        private System.Windows.Forms.DateTimePicker dtpHora;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.ComboBox cbxMotivo;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblFechaReconsulta;
        private System.Windows.Forms.Label lblMotivoConsulta;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblBusqueda;
        private System.Windows.Forms.TextBox txtParametro;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.GroupBox gbxLista;
        private System.Windows.Forms.DataGridView dgvLista;
        private System.Windows.Forms.Label lblMotivo;
        private System.Windows.Forms.Panel pnlAcciones;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.TextBox txtMotivo;
        private System.Windows.Forms.ErrorProvider erpCita;
        private System.Windows.Forms.ErrorProvider erpMotivo;
        private System.Windows.Forms.Label lblAutor;
    }
}
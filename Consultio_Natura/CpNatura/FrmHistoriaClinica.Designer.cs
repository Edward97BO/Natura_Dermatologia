namespace CpNatura
{
    partial class FrmHistoriaClinica
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
            this.lblAntecedentes = new System.Windows.Forms.Label();
            this.cbxPaciente = new System.Windows.Forms.ComboBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
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
            this.cbxDermatologo = new System.Windows.Forms.ComboBox();
            this.lblDermatologo = new System.Windows.Forms.Label();
            this.txtAntecedentes = new System.Windows.Forms.TextBox();
            this.txtSintomas = new System.Windows.Forms.TextBox();
            this.lblSintomas = new System.Windows.Forms.Label();
            this.txtDiagnostico = new System.Windows.Forms.TextBox();
            this.lblDiagnosticos = new System.Windows.Forms.Label();
            this.txtTratamientos = new System.Windows.Forms.TextBox();
            this.lblTratamientos = new System.Windows.Forms.Label();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.lblObservaciones = new System.Windows.Forms.Label();
            this.erpPaciente = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpDermatologo = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpAntecedentes = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpSintomas = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpDiagnosticos = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpTratamientos = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpObservaciones = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlDatos.SuspendLayout();
            this.gbxDatos.SuspendLayout();
            this.gbxLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            this.pnlAcciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpPaciente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpDermatologo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpAntecedentes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpSintomas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpDiagnosticos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpTratamientos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpObservaciones)).BeginInit();
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
            this.pnlDatos.TabIndex = 4;
            // 
            // gbxDatos
            // 
            this.gbxDatos.Controls.Add(this.txtObservaciones);
            this.gbxDatos.Controls.Add(this.lblObservaciones);
            this.gbxDatos.Controls.Add(this.txtTratamientos);
            this.gbxDatos.Controls.Add(this.lblTratamientos);
            this.gbxDatos.Controls.Add(this.txtDiagnostico);
            this.gbxDatos.Controls.Add(this.lblDiagnosticos);
            this.gbxDatos.Controls.Add(this.txtSintomas);
            this.gbxDatos.Controls.Add(this.lblSintomas);
            this.gbxDatos.Controls.Add(this.txtAntecedentes);
            this.gbxDatos.Controls.Add(this.cbxDermatologo);
            this.gbxDatos.Controls.Add(this.lblDermatologo);
            this.gbxDatos.Controls.Add(this.lblAntecedentes);
            this.gbxDatos.Controls.Add(this.cbxPaciente);
            this.gbxDatos.Controls.Add(this.btnCancelar);
            this.gbxDatos.Controls.Add(this.btnGuardar);
            this.gbxDatos.Controls.Add(this.lblPaciente);
            this.gbxDatos.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxDatos.ForeColor = System.Drawing.SystemColors.Control;
            this.gbxDatos.Location = new System.Drawing.Point(17, 13);
            this.gbxDatos.Name = "gbxDatos";
            this.gbxDatos.Size = new System.Drawing.Size(276, 590);
            this.gbxDatos.TabIndex = 0;
            this.gbxDatos.TabStop = false;
            this.gbxDatos.Text = "Datos de Historia Clínica:";
            // 
            // lblAntecedentes
            // 
            this.lblAntecedentes.AutoSize = true;
            this.lblAntecedentes.Location = new System.Drawing.Point(15, 148);
            this.lblAntecedentes.Name = "lblAntecedentes";
            this.lblAntecedentes.Size = new System.Drawing.Size(143, 22);
            this.lblAntecedentes.TabIndex = 23;
            this.lblAntecedentes.Text = "Antecedentes:";
            // 
            // cbxPaciente
            // 
            this.cbxPaciente.FormattingEnabled = true;
            this.cbxPaciente.Location = new System.Drawing.Point(19, 50);
            this.cbxPaciente.Name = "cbxPaciente";
            this.cbxPaciente.Size = new System.Drawing.Size(233, 30);
            this.cbxPaciente.TabIndex = 18;
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
            // lblPaciente
            // 
            this.lblPaciente.AutoSize = true;
            this.lblPaciente.Location = new System.Drawing.Point(18, 25);
            this.lblPaciente.Name = "lblPaciente";
            this.lblPaciente.Size = new System.Drawing.Size(96, 22);
            this.lblPaciente.TabIndex = 0;
            this.lblPaciente.Text = "Paciente:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Cooper Black", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(230)))), ((int)(((byte)(211)))));
            this.lblTitulo.Location = new System.Drawing.Point(3, 65);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(766, 46);
            this.lblTitulo.TabIndex = 5;
            this.lblTitulo.Text = "HISTORIAS CLÍNICAS";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblBusqueda
            // 
            this.lblBusqueda.AutoSize = true;
            this.lblBusqueda.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusqueda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(237)))), ((int)(((byte)(229)))));
            this.lblBusqueda.Location = new System.Drawing.Point(82, 161);
            this.lblBusqueda.Name = "lblBusqueda";
            this.lblBusqueda.Size = new System.Drawing.Size(316, 21);
            this.lblBusqueda.TabIndex = 6;
            this.lblBusqueda.Text = "Buscar por nombre de Paciente:";
            // 
            // txtParametro
            // 
            this.txtParametro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(237)))), ((int)(((byte)(229)))));
            this.txtParametro.Location = new System.Drawing.Point(86, 196);
            this.txtParametro.Name = "txtParametro";
            this.txtParametro.Size = new System.Drawing.Size(444, 20);
            this.txtParametro.TabIndex = 7;
            this.txtParametro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtParametro_KeyPress);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(237)))), ((int)(((byte)(229)))));
            this.btnBuscar.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.Teal;
            this.btnBuscar.Image = global::CpNatura.Properties.Resources.Busca;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(569, 161);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(118, 55);
            this.btnBuscar.TabIndex = 8;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // gbxLista
            // 
            this.gbxLista.Controls.Add(this.dgvLista);
            this.gbxLista.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxLista.Location = new System.Drawing.Point(86, 244);
            this.gbxLista.Name = "gbxLista";
            this.gbxLista.Size = new System.Drawing.Size(595, 188);
            this.gbxLista.TabIndex = 9;
            this.gbxLista.TabStop = false;
            this.gbxLista.Text = "Lista de Historias Clinicas:";
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
            this.pnlAcciones.Location = new System.Drawing.Point(86, 458);
            this.pnlAcciones.Name = "pnlAcciones";
            this.pnlAcciones.Size = new System.Drawing.Size(595, 94);
            this.pnlAcciones.TabIndex = 10;
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
            // cbxDermatologo
            // 
            this.cbxDermatologo.FormattingEnabled = true;
            this.cbxDermatologo.Location = new System.Drawing.Point(16, 108);
            this.cbxDermatologo.Name = "cbxDermatologo";
            this.cbxDermatologo.Size = new System.Drawing.Size(233, 30);
            this.cbxDermatologo.TabIndex = 25;
            // 
            // lblDermatologo
            // 
            this.lblDermatologo.AutoSize = true;
            this.lblDermatologo.Location = new System.Drawing.Point(15, 83);
            this.lblDermatologo.Name = "lblDermatologo";
            this.lblDermatologo.Size = new System.Drawing.Size(134, 22);
            this.lblDermatologo.TabIndex = 24;
            this.lblDermatologo.Text = "Dermatólogo:";
            // 
            // txtAntecedentes
            // 
            this.txtAntecedentes.Location = new System.Drawing.Point(16, 174);
            this.txtAntecedentes.Name = "txtAntecedentes";
            this.txtAntecedentes.Size = new System.Drawing.Size(233, 29);
            this.txtAntecedentes.TabIndex = 26;
            // 
            // txtSintomas
            // 
            this.txtSintomas.Location = new System.Drawing.Point(19, 232);
            this.txtSintomas.Name = "txtSintomas";
            this.txtSintomas.Size = new System.Drawing.Size(233, 29);
            this.txtSintomas.TabIndex = 28;
            // 
            // lblSintomas
            // 
            this.lblSintomas.AutoSize = true;
            this.lblSintomas.Location = new System.Drawing.Point(18, 206);
            this.lblSintomas.Name = "lblSintomas";
            this.lblSintomas.Size = new System.Drawing.Size(101, 22);
            this.lblSintomas.TabIndex = 27;
            this.lblSintomas.Text = "Síntomas:";
            // 
            // txtDiagnostico
            // 
            this.txtDiagnostico.Location = new System.Drawing.Point(19, 290);
            this.txtDiagnostico.Name = "txtDiagnostico";
            this.txtDiagnostico.Size = new System.Drawing.Size(233, 29);
            this.txtDiagnostico.TabIndex = 30;
            // 
            // lblDiagnosticos
            // 
            this.lblDiagnosticos.AutoSize = true;
            this.lblDiagnosticos.Location = new System.Drawing.Point(18, 264);
            this.lblDiagnosticos.Name = "lblDiagnosticos";
            this.lblDiagnosticos.Size = new System.Drawing.Size(134, 22);
            this.lblDiagnosticos.TabIndex = 29;
            this.lblDiagnosticos.Text = "Diagnósticos:";
            // 
            // txtTratamientos
            // 
            this.txtTratamientos.Location = new System.Drawing.Point(19, 348);
            this.txtTratamientos.Name = "txtTratamientos";
            this.txtTratamientos.Size = new System.Drawing.Size(233, 29);
            this.txtTratamientos.TabIndex = 32;
            // 
            // lblTratamientos
            // 
            this.lblTratamientos.AutoSize = true;
            this.lblTratamientos.Location = new System.Drawing.Point(18, 322);
            this.lblTratamientos.Name = "lblTratamientos";
            this.lblTratamientos.Size = new System.Drawing.Size(137, 22);
            this.lblTratamientos.TabIndex = 31;
            this.lblTratamientos.Text = "Tratamientos:";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(19, 411);
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(233, 29);
            this.txtObservaciones.TabIndex = 34;
            // 
            // lblObservaciones
            // 
            this.lblObservaciones.AutoSize = true;
            this.lblObservaciones.Location = new System.Drawing.Point(18, 385);
            this.lblObservaciones.Name = "lblObservaciones";
            this.lblObservaciones.Size = new System.Drawing.Size(152, 22);
            this.lblObservaciones.TabIndex = 33;
            this.lblObservaciones.Text = "Observaciones:";
            // 
            // erpPaciente
            // 
            this.erpPaciente.ContainerControl = this;
            // 
            // erpDermatologo
            // 
            this.erpDermatologo.ContainerControl = this;
            // 
            // erpAntecedentes
            // 
            this.erpAntecedentes.ContainerControl = this;
            // 
            // erpSintomas
            // 
            this.erpSintomas.ContainerControl = this;
            // 
            // erpDiagnosticos
            // 
            this.erpDiagnosticos.ContainerControl = this;
            // 
            // erpTratamientos
            // 
            this.erpTratamientos.ContainerControl = this;
            // 
            // erpObservaciones
            // 
            this.erpObservaciones.ContainerControl = this;
            // 
            // FrmHistoriaClinica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(156)))), ((int)(((byte)(137)))));
            this.ClientSize = new System.Drawing.Size(1080, 615);
            this.Controls.Add(this.pnlAcciones);
            this.Controls.Add(this.gbxLista);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtParametro);
            this.Controls.Add(this.lblBusqueda);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pnlDatos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmHistoriaClinica";
            this.Text = "FrmHistoriaClinica";
            this.Load += new System.EventHandler(this.FrmHistoriaClinica_Load);
            this.pnlDatos.ResumeLayout(false);
            this.gbxDatos.ResumeLayout(false);
            this.gbxDatos.PerformLayout();
            this.gbxLista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            this.pnlAcciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.erpPaciente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpDermatologo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpAntecedentes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpSintomas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpDiagnosticos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpTratamientos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpObservaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlDatos;
        private System.Windows.Forms.GroupBox gbxDatos;
        private System.Windows.Forms.Label lblAntecedentes;
        private System.Windows.Forms.ComboBox cbxPaciente;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
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
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.Label lblObservaciones;
        private System.Windows.Forms.TextBox txtTratamientos;
        private System.Windows.Forms.Label lblTratamientos;
        private System.Windows.Forms.TextBox txtDiagnostico;
        private System.Windows.Forms.Label lblDiagnosticos;
        private System.Windows.Forms.TextBox txtSintomas;
        private System.Windows.Forms.Label lblSintomas;
        private System.Windows.Forms.TextBox txtAntecedentes;
        private System.Windows.Forms.ComboBox cbxDermatologo;
        private System.Windows.Forms.Label lblDermatologo;
        private System.Windows.Forms.ErrorProvider erpPaciente;
        private System.Windows.Forms.ErrorProvider erpDermatologo;
        private System.Windows.Forms.ErrorProvider erpAntecedentes;
        private System.Windows.Forms.ErrorProvider erpSintomas;
        private System.Windows.Forms.ErrorProvider erpDiagnosticos;
        private System.Windows.Forms.ErrorProvider erpTratamientos;
        private System.Windows.Forms.ErrorProvider erpObservaciones;
    }
}
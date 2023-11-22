namespace CpNatura
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.lblNatura = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnHistoriaClinica = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnReconsulta = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnPago = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnDermatologo = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnCita = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnPaciente = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnUsuario = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.pnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(230)))), ((int)(((byte)(211)))));
            this.pnlTitulo.Controls.Add(this.btnMinimizar);
            this.pnlTitulo.Controls.Add(this.btnCerrar);
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(1300, 35);
            this.pnlTitulo.TabIndex = 0;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.Image = global::CpNatura.Properties.Resources.Minimizar;
            this.btnMinimizar.Location = new System.Drawing.Point(1232, 3);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(25, 25);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 1;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Image = global::CpNatura.Properties.Resources.Salir;
            this.btnCerrar.Location = new System.Drawing.Point(1263, 4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(25, 25);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(120)))), ((int)(((byte)(104)))));
            this.pnlMenu.Controls.Add(this.lblNatura);
            this.pnlMenu.Controls.Add(this.panel7);
            this.pnlMenu.Controls.Add(this.btnHistoriaClinica);
            this.pnlMenu.Controls.Add(this.panel6);
            this.pnlMenu.Controls.Add(this.btnReconsulta);
            this.pnlMenu.Controls.Add(this.panel5);
            this.pnlMenu.Controls.Add(this.btnPago);
            this.pnlMenu.Controls.Add(this.panel3);
            this.pnlMenu.Controls.Add(this.btnDermatologo);
            this.pnlMenu.Controls.Add(this.panel4);
            this.pnlMenu.Controls.Add(this.btnCita);
            this.pnlMenu.Controls.Add(this.panel2);
            this.pnlMenu.Controls.Add(this.btnPaciente);
            this.pnlMenu.Controls.Add(this.panel1);
            this.pnlMenu.Controls.Add(this.btnUsuario);
            this.pnlMenu.Controls.Add(this.pictureBox1);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 35);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(220, 615);
            this.pnlMenu.TabIndex = 1;
            // 
            // lblNatura
            // 
            this.lblNatura.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNatura.ForeColor = System.Drawing.Color.White;
            this.lblNatura.Location = new System.Drawing.Point(23, 203);
            this.lblNatura.Name = "lblNatura";
            this.lblNatura.Size = new System.Drawing.Size(168, 23);
            this.lblNatura.TabIndex = 15;
            this.lblNatura.Text = "NATURA";
            this.lblNatura.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(230)))), ((int)(((byte)(211)))));
            this.panel7.Location = new System.Drawing.Point(12, 445);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(10, 32);
            this.panel7.TabIndex = 14;
            // 
            // btnHistoriaClinica
            // 
            this.btnHistoriaClinica.FlatAppearance.BorderSize = 0;
            this.btnHistoriaClinica.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(230)))), ((int)(((byte)(211)))));
            this.btnHistoriaClinica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistoriaClinica.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistoriaClinica.ForeColor = System.Drawing.Color.White;
            this.btnHistoriaClinica.Image = global::CpNatura.Properties.Resources.salud;
            this.btnHistoriaClinica.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHistoriaClinica.Location = new System.Drawing.Point(28, 445);
            this.btnHistoriaClinica.Name = "btnHistoriaClinica";
            this.btnHistoriaClinica.Size = new System.Drawing.Size(186, 32);
            this.btnHistoriaClinica.TabIndex = 13;
            this.btnHistoriaClinica.Text = "H. CLÍNICA";
            this.btnHistoriaClinica.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHistoriaClinica.UseVisualStyleBackColor = true;
            this.btnHistoriaClinica.Click += new System.EventHandler(this.btnHistoriaClinica_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(230)))), ((int)(((byte)(211)))));
            this.panel6.Location = new System.Drawing.Point(12, 483);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(10, 32);
            this.panel6.TabIndex = 12;
            // 
            // btnReconsulta
            // 
            this.btnReconsulta.FlatAppearance.BorderSize = 0;
            this.btnReconsulta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(230)))), ((int)(((byte)(211)))));
            this.btnReconsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReconsulta.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReconsulta.ForeColor = System.Drawing.Color.White;
            this.btnReconsulta.Image = global::CpNatura.Properties.Resources.cita;
            this.btnReconsulta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReconsulta.Location = new System.Drawing.Point(28, 483);
            this.btnReconsulta.Name = "btnReconsulta";
            this.btnReconsulta.Size = new System.Drawing.Size(186, 32);
            this.btnReconsulta.TabIndex = 11;
            this.btnReconsulta.Text = "RECONSULTAS";
            this.btnReconsulta.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnReconsulta.UseVisualStyleBackColor = true;
            this.btnReconsulta.Click += new System.EventHandler(this.btnReconsulta_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(230)))), ((int)(((byte)(211)))));
            this.panel5.Location = new System.Drawing.Point(12, 407);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(10, 32);
            this.panel5.TabIndex = 10;
            // 
            // btnPago
            // 
            this.btnPago.FlatAppearance.BorderSize = 0;
            this.btnPago.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(230)))), ((int)(((byte)(211)))));
            this.btnPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPago.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPago.ForeColor = System.Drawing.Color.White;
            this.btnPago.Image = global::CpNatura.Properties.Resources.metodo_de_pago;
            this.btnPago.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPago.Location = new System.Drawing.Point(28, 407);
            this.btnPago.Name = "btnPago";
            this.btnPago.Size = new System.Drawing.Size(186, 32);
            this.btnPago.TabIndex = 9;
            this.btnPago.Text = "PAGOS";
            this.btnPago.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPago.UseVisualStyleBackColor = true;
            this.btnPago.Click += new System.EventHandler(this.btnPago_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(230)))), ((int)(((byte)(211)))));
            this.panel3.Location = new System.Drawing.Point(12, 369);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 32);
            this.panel3.TabIndex = 8;
            // 
            // btnDermatologo
            // 
            this.btnDermatologo.FlatAppearance.BorderSize = 0;
            this.btnDermatologo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(230)))), ((int)(((byte)(211)))));
            this.btnDermatologo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDermatologo.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDermatologo.ForeColor = System.Drawing.Color.White;
            this.btnDermatologo.Image = global::CpNatura.Properties.Resources.equipo_medico;
            this.btnDermatologo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDermatologo.Location = new System.Drawing.Point(28, 369);
            this.btnDermatologo.Name = "btnDermatologo";
            this.btnDermatologo.Size = new System.Drawing.Size(186, 32);
            this.btnDermatologo.TabIndex = 7;
            this.btnDermatologo.Text = "MÉDICOS";
            this.btnDermatologo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDermatologo.UseVisualStyleBackColor = true;
            this.btnDermatologo.Click += new System.EventHandler(this.btnDermatologo_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(230)))), ((int)(((byte)(211)))));
            this.panel4.Location = new System.Drawing.Point(12, 331);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 32);
            this.panel4.TabIndex = 6;
            // 
            // btnCita
            // 
            this.btnCita.FlatAppearance.BorderSize = 0;
            this.btnCita.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(230)))), ((int)(((byte)(211)))));
            this.btnCita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCita.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCita.ForeColor = System.Drawing.Color.White;
            this.btnCita.Image = global::CpNatura.Properties.Resources.consulta;
            this.btnCita.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCita.Location = new System.Drawing.Point(28, 331);
            this.btnCita.Name = "btnCita";
            this.btnCita.Size = new System.Drawing.Size(186, 32);
            this.btnCita.TabIndex = 5;
            this.btnCita.Text = "CONSULTAS";
            this.btnCita.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCita.UseVisualStyleBackColor = true;
            this.btnCita.Click += new System.EventHandler(this.btnCita_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(230)))), ((int)(((byte)(211)))));
            this.panel2.Location = new System.Drawing.Point(12, 293);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 32);
            this.panel2.TabIndex = 4;
            // 
            // btnPaciente
            // 
            this.btnPaciente.FlatAppearance.BorderSize = 0;
            this.btnPaciente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(230)))), ((int)(((byte)(211)))));
            this.btnPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaciente.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaciente.ForeColor = System.Drawing.Color.White;
            this.btnPaciente.Image = global::CpNatura.Properties.Resources.paciente;
            this.btnPaciente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPaciente.Location = new System.Drawing.Point(28, 293);
            this.btnPaciente.Name = "btnPaciente";
            this.btnPaciente.Size = new System.Drawing.Size(186, 32);
            this.btnPaciente.TabIndex = 3;
            this.btnPaciente.Text = "PACIENTES";
            this.btnPaciente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPaciente.UseVisualStyleBackColor = true;
            this.btnPaciente.Click += new System.EventHandler(this.btnPaciente_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(230)))), ((int)(((byte)(211)))));
            this.panel1.Location = new System.Drawing.Point(12, 255);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 32);
            this.panel1.TabIndex = 2;
            // 
            // btnUsuario
            // 
            this.btnUsuario.FlatAppearance.BorderSize = 0;
            this.btnUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(230)))), ((int)(((byte)(211)))));
            this.btnUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuario.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuario.ForeColor = System.Drawing.Color.White;
            this.btnUsuario.Image = global::CpNatura.Properties.Resources.Usuario;
            this.btnUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuario.Location = new System.Drawing.Point(28, 255);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Size = new System.Drawing.Size(186, 32);
            this.btnUsuario.TabIndex = 1;
            this.btnUsuario.Text = "USUARIOS";
            this.btnUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUsuario.UseVisualStyleBackColor = true;
            this.btnUsuario.Click += new System.EventHandler(this.btnUsuario_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CpNatura.Properties.Resources.LogoNatura;
            this.pictureBox1.Location = new System.Drawing.Point(23, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(168, 178);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(156)))), ((int)(((byte)(137)))));
            this.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedor.Location = new System.Drawing.Point(220, 35);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(1080, 615);
            this.pnlContenedor.TabIndex = 2;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 650);
            this.Controls.Add(this.pnlContenedor);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPrincipal";
            this.pnlTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.pnlMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlContenedor;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnUsuario;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnDermatologo;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnCita;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnPaciente;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnHistoriaClinica;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnReconsulta;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnPago;
        private System.Windows.Forms.Label lblNatura;
    }
}
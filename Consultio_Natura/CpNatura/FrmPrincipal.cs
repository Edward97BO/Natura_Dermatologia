﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Hierarchy;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CpNatura
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void abrirFrmHijo(object frmHijo)
        {
            if (this.pnlContenedor.Controls.Count > 0)
                this.pnlContenedor.Controls.RemoveAt(0);
            Form fh = frmHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.pnlContenedor.Controls.Add(fh);
            this.pnlContenedor.Tag = fh;
            fh.Show();
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            abrirFrmHijo(new FrmUsuario());
        }

        private void btnPaciente_Click(object sender, EventArgs e)
        {
            abrirFrmHijo(new FrmPaciente());
        }

        private void btnCita_Click(object sender, EventArgs e)
        {
            abrirFrmHijo(new FrmCita());
        }

        private void btnDermatologo_Click(object sender, EventArgs e)
        {
            abrirFrmHijo(new FrmMedico());
        }
    }
}

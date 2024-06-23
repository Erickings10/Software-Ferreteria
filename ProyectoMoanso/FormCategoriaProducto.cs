﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoMoanso
{
    public partial class FormCategoriaProducto : Form
    {
        public FormCategoriaProducto()
        {
            InitializeComponent();
            gbBotones.Enabled = false;
            dgvCategoriaPro.Enabled = false;
            gboxDatos.Enabled = false;
            txtId.Enabled = false;
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            gbBotones.Enabled = true;
            dgvCategoriaPro.Enabled = true;
            gboxDatos.Enabled = true;
        }
    }
}

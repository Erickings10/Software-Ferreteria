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
    public partial class FormPagoFactura : Form
    {
        public FormPagoFactura()
        {
            InitializeComponent();
            txtMontoFac.Enabled = false;
            txtpProveedorFac.Enabled = false;
        }
    }
}
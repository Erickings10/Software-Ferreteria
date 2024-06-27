using System;
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

    public partial class FormMetodoPago : Form
    {
        public FormMetodoPago()
        {
            InitializeComponent();
            gboxDatos.Enabled = false;
            gbBotones.Enabled = false;
            dgvMetodos.Enabled = false;
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            gboxDatos.Enabled = true;
            gbBotones.Enabled = true;
            dgvMetodos.Enabled = true; 
        }
    }
}

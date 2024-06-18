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
    public partial class dgv_productosRequeridos : Form
    {
        public dgv_productosRequeridos()
        {
            InitializeComponent();
        }
        private void AbrirFormSecundario()
        {
            using (FormReporteProveedores frmReporteProovedor = new FormReporteProveedores())
            {
                if (frmReporteProovedor.ShowDialog() == DialogResult.OK)
                {
                    txtProovedor.Text = frmReporteProovedor.sectorProve;
 
                }
            }
        }
        private void btnProovedor_Click(object sender, EventArgs e)
        {
            AbrirFormSecundario();
        }
    }
}

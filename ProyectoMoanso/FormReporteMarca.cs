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
    public partial class FormReporteMarca : Form
    {
        public string Marca { get; set; }

        public FormReporteMarca()
        {
            InitializeComponent();
        }
        private void AbrirMarcaProducto()
        {
            using (FormMarcaProducto frmMarcaProducto = new FormMarcaProducto())
            {
                if (frmMarcaProducto.ShowDialog() == DialogResult.OK)
                {
                    frmMarcaProducto.Show();
                }

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            AbrirMarcaProducto();
        }
    }
}

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
    public partial class FormReporteCategoria : Form
    {
        public string Categoria { get; set; }

        public FormReporteCategoria()
        {
            InitializeComponent();
        }

        private void AbrirMarcaProducto()
        {
            using (FormCategoriaProducto frmCategoriaProducto = new FormCategoriaProducto())
            {
                if (frmCategoriaProducto.ShowDialog() == DialogResult.OK)
                {
                    frmCategoriaProducto.Show();
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

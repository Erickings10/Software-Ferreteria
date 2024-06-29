using CapaLogica;
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
        public string IdCategoria { get; set; }

        public FormReporteCategoria()
        {
            InitializeComponent();
            ListarReporteCategoria();
            CambiarEncabezados();
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

        public void CambiarEncabezados()
        {
            dgvReporteCategoria.Columns["CategoriaproductoID"].HeaderText = "ID Categoria";
            dgvReporteCategoria.Columns["categoria"].HeaderText = "Categoria Producto";
            dgvReporteCategoria.Columns["estado"].HeaderText = "Estado";
        }

        public void ListarReporteCategoria()
        {
            dgvReporteCategoria.DataSource = logCategoriaProductos.Instancia.ListarReporteCategoriaProducto();
        }

        private void dgvReporteCategoria_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvReporteCategoria.Rows[e.RowIndex];

            // Si el estado es true, asignar los valores
            IdCategoria = filaActual.Cells[0].Value.ToString();
            Categoria = filaActual.Cells[1].Value.ToString();
            


            DialogResult = DialogResult.OK;  // Esto cierra el formulario y devuelve el resultado a FormPrincipal
            Close();
        }
    }
}

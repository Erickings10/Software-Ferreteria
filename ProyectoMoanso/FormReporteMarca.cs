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
    public partial class FormReporteMarca : Form
    {
        public string Marca { get; set; }
        public string IdMarca { get; set; }

        public FormReporteMarca()
        {
            InitializeComponent();
            ListarMarca();
            CambiarEncabezados();
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
        public void CambiarEncabezados()
        {
            dgvReporteMarca.Columns["MarcaproductoID"].HeaderText = "ID Marca";
            dgvReporteMarca.Columns["marca"].HeaderText = "Marca Producto";
            dgvReporteMarca.Columns["estado"].HeaderText = "Estado";
        }
        public void ListarMarca()
        {
            dgvReporteMarca.DataSource = logMarcaProducto.Instancia.ListarReporteMarcaProducto();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvReporteMarca.Rows[e.RowIndex];

            // Si el estado es true, asignar los valores
            IdMarca = filaActual.Cells[0].Value.ToString();
            Marca = filaActual.Cells[1].Value.ToString();


            DialogResult = DialogResult.OK;  // Esto cierra el formulario y devuelve el resultado a FormPrincipal
            Close();

        }
    }
}

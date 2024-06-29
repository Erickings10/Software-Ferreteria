using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoMoanso
{
    public partial class FormReporteProducto : Form
    {
        public string Producto { get; set; }
        public string IdProducto { get; set; }

        public FormReporteProducto()
        {
            InitializeComponent();
            ListarProductos();
            CambiarEncabezados();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void ListarProductos()
        {
                dgvReporteProductos.DataSource = logProductos.Instancia.ListarReporteProducto();

        }
        public void CambiarEncabezados()
        {
            dgvReporteProductos.Columns["ProductoID"].HeaderText = "ID Producto";
            dgvReporteProductos.Columns["categoria"].HeaderText = "Categoria";
            dgvReporteProductos.Columns["marca"].HeaderText = "Marca";
            dgvReporteProductos.Columns["descripcion"].HeaderText = "Descripcion";
            dgvReporteProductos.Columns["cantidad"].HeaderText = "Cantidad";
            dgvReporteProductos.Columns["estado"].HeaderText = "Estado";
        }

        private void dgvReporteProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvReporteProductos.Rows[e.RowIndex];

            // Si el estado es true, asignar los valores
            IdProducto = filaActual.Cells[0].Value.ToString();
            Producto = filaActual.Cells[3].Value.ToString();


            DialogResult = DialogResult.OK;  // Esto cierra el formulario y devuelve el resultado a FormPrincipal
            Close();
        }
    }
}

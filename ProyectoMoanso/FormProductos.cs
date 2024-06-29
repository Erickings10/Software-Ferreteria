using CapaEntidad;
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
    public partial class FormProductos : Form
    {
        public FormProductos()
        {
            InitializeComponent();
            txtCodigo.Enabled = false;
            gboBotones1.Enabled = true;
            gbBotones2.Enabled = false;
            gboDatos.Enabled = false;
            dgvRegistroProducto.Enabled = false;
            txtCategoria.Enabled = false;
            //txtProveedor.Enabled = false;
            txtMarca.Enabled = false;
            listarProducto();
            CambiarEncabezados();
            txtIdMarca.Visible = false;
            txtIdCategoria.Visible = false;
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                errorStock.SetError(txtCantidad, "Solo ingrese numeros");
            }
            else
            {
                errorStock.SetError(txtCantidad, "");
            }
        }
        private void LimpiarVariables()
        {
            txtDescripcion.Text = "";
            txtMarca.Text = "";
            txtCategoria.Text = "";
            txtCantidad.Text = "";
            chbx_Estado.Checked = false;

        }
        public void CambiarEncabezados()
        {
            dgvRegistroProducto.Columns["categoria"].HeaderText = "Categoria";
            dgvRegistroProducto.Columns["marca"].HeaderText = "Marca";
            dgvRegistroProducto.Columns["descripcion"].HeaderText = "Descripcion";
            dgvRegistroProducto.Columns["cantidad"].HeaderText = "Cantidad";
            dgvRegistroProducto.Columns["estado"].HeaderText = "Estado";
        }

        public void listarProducto()
        {
            dgvRegistroProducto.DataSource = logProductos.Instancia.ListarProductos();
        }

        private void btn_Guardar_Produc_Click(object sender, EventArgs e)
        {

            //insertar
            try
            {
                entProductos p = new entProductos();

                p.CategoriaproductoID = Convert.ToInt32(txtIdCategoria.Text);
                p.MarcaproductoID = Convert.ToInt32(txtIdMarca.Text);
                p.descripcion = txtDescripcion.Text;
                p.cantidad = Convert.ToInt64(txtCantidad.Text);
                p.estado = Convert.ToBoolean(chbx_Estado.Checked);

                logProductos.Instancia.InsertaProductos(p);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }

            LimpiarVariables();

            listarProducto();
        }

        private void Limpiar()
        {
            txtCodigo.Text = "";
            txtMarca.Text = "";
            txtCategoria.Text = "";
            txtDescripcion.Text = "";
            txtCantidad.Text = "";
            chbx_Estado.Checked = false;
        }

        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            
            gboBotones1.Enabled = true;
            gbBotones2.Enabled = true;
            gboDatos.Enabled = true;
            dgvRegistroProducto.Enabled = true;
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            gboBotones1.Enabled = true;
            gbBotones2.Enabled = false;
            gboDatos.Enabled = false;
            dgvRegistroProducto.Enabled = false;
        }
        private void AbrirReporteMarca()
        {
            using (FormReporteMarca formReporteMarca = new FormReporteMarca())
            {
                if (formReporteMarca.ShowDialog() == DialogResult.OK)
                {
                    txtMarca.Text = formReporteMarca.Marca;
                    txtIdMarca.Text = formReporteMarca.IdMarca;
                }

            }
        }

        private void AbrirReporteCategoria()
        {
            using (FormReporteCategoria formReporteCateg = new FormReporteCategoria())
            {
                if (formReporteCateg.ShowDialog() == DialogResult.OK)
                {
                    txtCategoria.Text = formReporteCateg.Categoria;
                    txtIdCategoria.Text = formReporteCateg.IdCategoria;
                }

            }
        }

        private void btnBuscarMarca_Click(object sender, EventArgs e)
        {
            AbrirReporteMarca();
        }


        private void btnBuscarCategoria_Click(object sender, EventArgs e)
        {
            AbrirReporteCategoria();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                entProductos c = new entProductos();
                c.ProductoID = int.Parse(txtCodigo.Text.Trim());
                c.MarcaproductoID = int.Parse(txtIdMarca.Text.Trim());
                c.CategoriaproductoID = int.Parse(txtIdCategoria.Text.Trim());
                c.descripcion = txtMarca.Text.Trim();
                c.cantidad = Convert.ToInt32(txtCantidad.Text);
                c.estado = chbx_Estado.Checked;
                logProductos.Instancia.EditarProducto(c);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            Limpiar();
            gboDatos.Enabled = false;
            listarProducto();
            btnActualizar.Enabled = false;
        }

        private void dgvRegistroProducto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvRegistroProducto.Rows[e.RowIndex]; //
            txtCodigo.Text = filaActual.Cells[0].Value.ToString();
            txtMarca.Text = filaActual.Cells[1].Value.ToString();
            txtCategoria.Text = filaActual.Cells[2].Value.ToString();
            txtDescripcion.Text = filaActual.Cells[3].Value.ToString();
            txtCantidad.Text = filaActual.Cells[4].Value.ToString();
            chbx_Estado.Checked = Convert.ToBoolean(filaActual.Cells[5].Value);

            btnActualizar.Enabled = true;
            btnDeshabilitar.Enabled = true;
        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtCodigo.Text, out int productoID))
            {
                try
                {
                    // Llama al método para obtener los IDs de Marca y Categoría
                    var (marcaProductoID, categoriaProductoID) = logProductos.Instancia.ObtenerProductoPorID(productoID);

                    // Asigna los valores a los TextBox correspondientes
                    txtIdMarca.Text = marcaProductoID.ToString();
                    txtIdCategoria.Text = categoriaProductoID.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}


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
            dgvRegistroProducto.Columns["CategoriaproductoID"].HeaderText = "Categoria";
            dgvRegistroProducto.Columns["MarcaproductoID"].HeaderText = "Marca";
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

                p.CategoriaproductoID = Convert.ToInt32(txtCategoria.Text);
                p.MarcaproductoID = Convert.ToInt32(txtMarca.Text);
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
                }

            }
        }
        private void AbrirReporteProveedor()
        {
            using (FormReporteProveedores frmReporteProovedor = new FormReporteProveedores())
            {
                if (frmReporteProovedor.ShowDialog() == DialogResult.OK)
                {


                    //txtProveedor.Text = frmReporteProovedor.sectorProve;


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

        private void btnBuscarProveedor_Click(object sender, EventArgs e)
        {
            AbrirReporteProveedor();
        }



    }
}


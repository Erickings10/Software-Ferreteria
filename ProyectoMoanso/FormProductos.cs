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
            txt_categoria_produc.Enabled = false;
            //txtProveedor.Enabled = false;
            txt_marca_produc.Enabled = false;
            //listarProducto();
        }

        private void txt_stock_produc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) 
            {
                e.Handled = true;
                errorStock.SetError(txtCantidad, "Solo ingrese numeros");
            }
            else 
            {
                errorStock.SetError(txtCantidad,"");
            }
        }



        public void listarProducto()
        {
            dgvRegistroProducto.DataSource = logProductos.Instancia.ListarProductos();
        }




        private void Productos_Load(object sender, EventArgs e)
        {

        }

        private void btn_Guardar_Produc_Click(object sender, EventArgs e)
        {

            //insertar
            try
            {
                entProductos p = new entProductos();

                p.Nombre_Producto = txtDescripcion.Text;

                p.Marca_Producto = txt_marca_produc.Text;

                p.Categoria_Producto = txt_categoria_produc.Text;

                p.Stock = Convert.ToInt32(txtCantidad.Text);

                logProductos.Instancia.InsertaProductos(p);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            
            LimpiarVariables();
           
            listarProducto();
        }




        private void LimpiarVariables()
        {
            txtDescripcion.Text = "";

            txt_marca_produc.Text = "";

            txt_categoria_produc.Text = "";

            txtCantidad.Text = "";

            //cbkEstadoCliente.Checked = false;

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
                    txt_marca_produc.Text = formReporteMarca.Marca;
                }

            }
        }

        private void AbrirReporteCategoria()
        {
            using (FormReporteCategoria formReporteCateg = new FormReporteCategoria())
            {
                if (formReporteCateg.ShowDialog() == DialogResult.OK)
                {
                    txt_categoria_produc.Text = formReporteCateg.Categoria;
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


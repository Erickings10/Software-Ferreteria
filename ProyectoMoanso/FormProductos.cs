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
            txt_codigo_produc.ReadOnly = true;
            txt_codigo_produc.Enabled = false;

            listarProducto();



        }

        private void txt_stock_produc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) 
            {
                e.Handled = true;
                errorStock.SetError(txt_stock_produc, "Solo ingrese numeros");
            }
            else 
            {
                errorStock.SetError(txt_stock_produc,"");
            }
        }



        public void listarProducto()
        {
            dgv_registro_productos.DataSource = logProductos.Instancia.ListarProductos();
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

                p.Nombre_Producto = txt_nombre_produc.Text;

                p.Marca_Producto = txt_marca_produc.Text;

                p.Categoria_Producto = txt_categoria_produc.Text;

                p.Stock = Convert.ToInt32(txt_stock_produc.Text);

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
            txt_nombre_produc.Text = "";

            txt_marca_produc.Text = "";

            txt_categoria_produc.Text = "";

            txt_stock_produc.Text = "";

            //cbkEstadoCliente.Checked = false;

        }






    }
}


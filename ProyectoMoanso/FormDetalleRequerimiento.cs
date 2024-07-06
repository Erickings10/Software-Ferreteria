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
    public partial class FormDetalleRequerimiento : Form
    {
        entRequerimiento requerimiento = new entRequerimiento();
        entDetRequerimiento detReq = new entDetRequerimiento();

        private List<entDetRequerimiento> listadetReq = new List<entDetRequerimiento>();

        public FormDetalleRequerimiento()
        {
            InitializeComponent();
            txtCodigo.Enabled = false;
        }
        public void CambiarEncabezados()
        {
            dgvNuevoReq.Columns["ProductoID"].HeaderText = "ID producto";
            dgvNuevoReq.Columns["descripcion"].HeaderText = "descripcion";

        }

        private void Limpiar()
        {
            txtProductoID.Text = "";
            txtCantidad.Text = " ";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscarPro_Click(object sender, EventArgs e)
        {
            txtProductoID.Focus();
            int idPro = Convert.ToInt32(txtProductoID.Text);
            entProductos prod = logProductos.Instancia.BuscarProductoId(idPro);
            if (prod != null && (prod.estado = true))
            {
                txtDescripcion.Text = Convert.ToString(prod.descripcion);
            }
            else
                MessageBox.Show("El producto no existe o esta inhabilitado, verifique", "Producto: Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        public static int confilas = 0;
        public static decimal Total = 0;

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            /*try
            {
                entRequerimiento c = new entRequerimiento();
                c.producto = txtProductoID.Text;
                c.cantidad = Convert.ToInt64(txtCantidad.Text);
                c.fecha = Convert.ToDateTime(dtmReque.Text);
                c.prioridad = cbPrioridad.Text;
                logRequerimientos.Instancia.InsertaRequerimiento(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            */


            Limpiar();
        }


    }
}
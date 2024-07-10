using CapaEntidad;
using CapaLogica;
using Org.BouncyCastle.Ocsp;
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
            //ListarDetalle();
        }

        /*private void ListarDetalle()
        {
            dgvDetalleRequerimiento.DataSource = logRequerimientos.Instancia.ListarRequerimientos();
        }*/
        public void CambiarEncabezados()
        {
            dgvDetalleRequerimiento.Columns["ProductoID"].HeaderText = "ID producto";
            dgvDetalleRequerimiento.Columns["descripcion"].HeaderText = "descripcion";

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
            // Verifica si el campo de cantidad está vacío o no es un número válido
            if (!int.TryParse(txtCantidad.Text, out int cantidad))
            {
                MessageBox.Show("Por favor, ingrese una cantidad válida.", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Verifica si los campos de texto están llenos
            if (string.IsNullOrEmpty(txtProductoID.Text) ||
                string.IsNullOrEmpty(txtDescripcion.Text) ||
                string.IsNullOrEmpty(cbPrioridad.Text))
            {
                MessageBox.Show("Seleccione un producto", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if ((txtProductoID.Text.Trim() != "") && (txtCantidad.Text.Trim() != ""))
            {
                if (Convert.ToInt32(txtCantidad.Text) > 0)
                {
                    // Añadir la nueva fila al DataGridView
                    dgvDetalleRequerimiento.Rows.Add(txtProductoID.Text, txtDescripcion.Text, txtCantidad.Text, cbPrioridad.Text);
                    // Limpiar los campos de entrada (opcional)
                    Limpiar();
                }
            }


        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            int idReq;
            try
            {
                entRequerimiento Req = new entRequerimiento();

                Req.fecha = Convert.ToDateTime(dtmReque.Value);
                Req.estado = true;

                idReq = logRequerimientos.Instancia.InsertarRequerimiento(Req);

                GrabarRequerimiento(idReq);

                Close();
                ActualizarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex);
                throw ex;
            }
        }

        private void GrabarRequerimiento(int cod)
        {
            foreach (DataGridViewRow Fila in dgvDetalleRequerimiento.Rows)
            {
                
                entDetalleRequerimiento detReq = new entDetalleRequerimiento    (); // Inicializar detReq dentro del bucle
                detReq.RequerimientoID = cod;

                entProductos prod = new entProductos();
                prod.ProductoID = Convert.ToInt32(Fila.Cells[0].Value.ToString());
                detReq.ProductoID = prod;

                logRequerimientos.Instancia.InsertarDetRequerimiento(detReq);
            }

        }
        private void ActualizarGrid()
        {

            //MessageBox.Show("formulario de datos se cierra....de si encuentra instancia");
            FormRequerimientosdeCompras frmRequerimiento = Application.OpenForms.OfType<FormRequerimientosdeCompras>().FirstOrDefault();

            if (frmRequerimiento != null)  //Si encuentra una instancia abierta
            {
                //MessageBox.Show("Instancia abierta!!! instancia");
                frmRequerimiento.listarRequerimiento();
                frmRequerimiento.Refresh();
            }
        }
    }
}
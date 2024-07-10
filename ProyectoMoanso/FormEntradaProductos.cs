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
    public partial class FormEntradaProductos : Form
    {
        public FormEntradaProductos()
        {
            InitializeComponent();
            gboDatos.Enabled = false;
            btnDeshabilitar.Enabled = false;
            btnModificar.Enabled = false;
            btnRegistrar.Enabled = false;
            txtidAlmacen.Visible = false;
            txtidProducto.Visible = false;
            txtProducto.Enabled= false;
            txtCodigo.Enabled = false;
            ListarEntrada();
            listarAlmacen();
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            gboDatos.Enabled = true;
            btnDeshabilitar.Enabled = true;
            btnModificar.Enabled = true;
            btnRegistrar.Enabled = true;
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            gboDatos.Enabled = false;
            btnDeshabilitar.Enabled = false;
            btnModificar.Enabled = false;
            btnRegistrar.Enabled = false;
        }
        private void LimpiarVariables()
        {
            txtCodigo.Text = "";
            cboAlmacen.Text = "";
            txtProducto.Text = "";
            txtCantidad.Text = "";
            dtpFechaEntrada.Text = "";
            chbx_Estado.Checked = false;

        }

        public void ListarEntrada()
        {
            dgvEntradaProductos.DataSource = logEntradaProductos.Instancia.ListarEntradaProducto();
            CambiarEncabezados();
        }

        public void listarAlmacen()
        {
            cboAlmacen.DataSource = logAlmacenes.Instancia.ListarAlmacenes();
            cboAlmacen.DisplayMember = "tipo";
            cboAlmacen.ValueMember = "AlmacenID";
        }
        private void CambiarEncabezados()
        {
            dgvEntradaProductos.Columns["DetalleentradaproductoID"].HeaderText = "ID Entrada";
            dgvEntradaProductos.Columns["AlmacenID"].HeaderText = "ID Almacen";
            dgvEntradaProductos.Columns["ProductoID"].HeaderText = "ID Producto";
            dgvEntradaProductos.Columns["cantidad"].HeaderText = "Cantidad";
            dgvEntradaProductos.Columns["descripcion"].HeaderText = "Descripcion";
            dgvEntradaProductos.Columns["fecha"].HeaderText = "Fecha";
            dgvEntradaProductos.Columns["estado"].HeaderText = "Estado";

        }
        private void AbrirReporteProductos()
        {
            using (FormReporteProducto formReporteProducto = new FormReporteProducto())
            {
                if (formReporteProducto.ShowDialog() == DialogResult.OK)
                {
                    txtProducto.Text = formReporteProducto.Producto;
                    txtidProducto.Text = formReporteProducto.IdProducto;
                }

            }
        }
        private void btnBuscarProductos_Click(object sender, EventArgs e)
        {
            AbrirReporteProductos();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                entEntradaProductos p = new entEntradaProductos();

                p.AlmacenID = Convert.ToInt32(txtidAlmacen.Text);
                p.ProductoID = Convert.ToInt32(txtidProducto.Text);
                p.cantidad = Convert.ToInt64(txtCantidad.Text);
                p.descripcion = txtDescripcion.Text;
                p.fecha = Convert.ToDateTime(dtpFechaEntrada.Text);
                p.estado = Convert.ToBoolean(chbx_Estado.Checked);

                logEntradaProductos.Instancia.InsertarEntradaProducto(p);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }

            LimpiarVariables();

            ListarEntrada();
        }


    }
}

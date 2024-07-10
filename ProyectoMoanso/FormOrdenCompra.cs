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
    public partial class dgv_productosRequeridos : Form
    {
        public dgv_productosRequeridos()
        {
            InitializeComponent();
            txtID.Enabled = false;
            txtOrdenCompra.Enabled = false;
            txtProovedor.Enabled = false;
      
        }
        private void AbrirFormProveedor()
        {
            using (FormReporteProveedores frmReporteProovedor = new FormReporteProveedores())
            {
                if (frmReporteProovedor.ShowDialog() == DialogResult.OK)
                {
                    txtProovedor.Text = frmReporteProovedor.sectorProve;
                }
            }
        }
        private void btnProovedor_Click(object sender, EventArgs e)
        {
            AbrirFormProveedor();
        }

        private void AbrirFormMetodo()
        {
            using ( FormReporteMetodos frmMetodoPago = new FormReporteMetodos())
            {
                if (frmMetodoPago.ShowDialog() == DialogResult.OK)
                {
                    txtProovedor.Text = frmMetodoPago.metodo;
                }

            }
        }

        private void btnBuscarMetodo_Click(object sender, EventArgs e)
        {
            AbrirFormMetodo();
        }

        private void AbrirFormDetalleOrden()
        {
            using (FormDetalleOrdenCompra frmDetalleOrden = new FormDetalleOrdenCompra())
            {
                if (frmDetalleOrden.ShowDialog() == DialogResult.OK)
                {
                    frmDetalleOrden.Show();

                }
            }
        }
        private void AbrirFormReporteDetalle()
        {
            using (FormReporteDetalleOrden frmreporteDetalleOrden = new FormReporteDetalleOrden())
            {
                if (frmreporteDetalleOrden.ShowDialog() == DialogResult.OK)
                {
                    txtOrdenCompra.Text = frmreporteDetalleOrden.ReporteDetalle;

                }
            }
        }

        private void btn_AgregarProducto_Click(object sender, EventArgs e)
        {
            //insertar
            try
            {
                entOrdendeCompra p = new entOrdendeCompra();

                p.OrdencompraID = Convert.ToInt32(txtID.Text);
                p.PagoordencompraID = Convert.ToInt32(txtOrdenCompra.Text);
                p.ProveedorID = Convert.ToInt32(txtProovedor.Text);
                p.Total = Convert.ToInt32(txtTotal.Text);
                p.Fecha = Convert.ToDateTime(dtpFecha.Text);
                p.Estado = Convert.ToBoolean(checkBoxEstado.Checked);

                logOrdendeCompra.Instancia.InsertaOrdenCompra(p);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }

            LimpiarVariables();
            listarOrden();
        }
        private void LimpiarVariables()
        {
            txtID.Text = "";
       
            txtProovedor.Text = "";
            txtTotal.Text = "";
            checkBoxEstado.Checked = false;
        }
        public void listarOrden()
        {
            dataGridView1.DataSource = logOrdendeCompra.Instancia.ListarOrdenCompra();
        }
        private void btnBuscarOrden_Click(object sender, EventArgs e)
        {
            AbrirFormReporteDetalle();
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Obtener la fila seleccionada
                DataGridViewRow row = dataGridView1.SelectedRows[0];

                // Asignar los valores de la fila a los TextBox correspondientes
                txtID.Text = row.Cells["OrdencompraID"].Value.ToString();
                txtOrdenCompra.Text = row.Cells["PagoordencompraID"].Value.ToString();
                txtProovedor.Text = row.Cells["ProveedorID"].Value.ToString();
                txtTotal.Text = row.Cells["Total"].Value.ToString();
            }
        }
        private void btn_Modificar_Click(object sender, EventArgs e)
        {

        }

        private void btn_Deshabilitar_Click(object sender, EventArgs e)
        {
            entOrdendeCompra orden = new entOrdendeCompra();
            orden.OrdencompraID = Convert.ToInt32(txtID.Text);
            orden.PagoordencompraID = Convert.ToInt32(txtOrdenCompra.Text);
            orden.ProveedorID = Convert.ToInt32(txtProovedor.Text);
            orden.Total = Convert.ToInt32(txtTotal.Text);
            logOrdendeCompra.Instancia.DeshabilitarOrdenCompra(orden);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
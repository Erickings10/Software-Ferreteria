using CapaEntidad;
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
            txtMetodo.Enabled = false;
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
            AbrirFormDetalleOrden();
        }

        private void btnBuscarOrden_Click(object sender, EventArgs e)
        {
            AbrirFormReporteDetalle();
        }
    }
}
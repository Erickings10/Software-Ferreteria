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
    public partial class FormRequerimientoNuevo : Form
    {
        public FormRequerimientoNuevo()
        {
            InitializeComponent();
            txtCodigo.Enabled = false;
            listarRequerimiento();
        }
        public void CambiarEncabezados()
        {
            dgvNuevoReq.Columns["id"].HeaderText = "ID de Requerimiento";
            dgvNuevoReq.Columns["producto"].HeaderText = "Producto";
            dgvNuevoReq.Columns["marca"].HeaderText = "Marca";
            dgvNuevoReq.Columns["categoria"].HeaderText = "Categoria";
            dgvNuevoReq.Columns["cantidad"].HeaderText = "Cantidad";
            dgvNuevoReq.Columns["fecha"].HeaderText = "Fecha";
            dgvNuevoReq.Columns["prioridad"].HeaderText = "Prioridad";
            dgvNuevoReq.Columns["estado"].HeaderText = "Estado";
        }

        private void Limpiar()
        {
            txtProducto.Text = "";
            txt_marca.Text = " ";
            txtCantidad.Text = " ";
            txtCategoria.Text = " ";
        }

        public void listarRequerimiento()
        {
            dgvNuevoReq.DataSource = logRequerimientos.Instancia.ListarRequerimientos();
            CambiarEncabezados();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                entRequerimiento c = new entRequerimiento();
                c.producto = txtProducto.Text;
                c.marca = txt_marca.Text;
                c.categoria = txtCategoria.Text;
                c.cantidad = Convert.ToInt64(txtCantidad.Text);
                c.fecha = Convert.ToDateTime(dtmReque.Text);
                c.prioridad = cbPrioridad.Text;
                c.estado = chboEstadoReque.Checked;
                logRequerimientos.Instancia.InsertaRequerimiento(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }



            Limpiar();
            listarRequerimiento();
        }
        private void AbrirReporteProducto()
        {
            using (FormReporteProducto frmReporteProducto = new FormReporteProducto())
            {
                if (frmReporteProducto.ShowDialog() == DialogResult.OK)
                {


                    txtProducto.Text = frmReporteProducto.Producto;


                }

            }
        }

        private void btnBuscarPro_Click(object sender, EventArgs e)
        {
            AbrirReporteProducto();
        }
    }
}
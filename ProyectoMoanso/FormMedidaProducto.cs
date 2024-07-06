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
    public partial class FormMedidaProducto : Form
    {
        public FormMedidaProducto()
        {
            InitializeComponent();
            gbBotones.Enabled = false;
            dgvMedidaPro.Enabled = false;
            gboxDatos.Enabled = false;
            txtId.Enabled = false;
            ListarMedida();
            CambiarEncabezados();
        }

        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            gbBotones.Enabled = true;
            dgvMedidaPro.Enabled = true;
            gboxDatos.Enabled = true;
            btnActualizar.Enabled = false;
            btnDeshabilitar.Enabled = false;
        }
        public void CambiarEncabezados()
        {
            dgvMedidaPro.Columns["MedidaproductoID"].HeaderText = "ID Medida";
            dgvMedidaPro.Columns["descripcion"].HeaderText = "Medida del Producto";
            dgvMedidaPro.Columns["prefijo"].HeaderText = "Predijo del Producto";
            dgvMedidaPro.Columns["estado"].HeaderText = "Estado";
        }
        private void Limpiar()
        {
            txtId.Text = "";
            txtDescripcion.Text = "";
            chbxEstado.Checked = false;
        }
        public void ListarMedida()
        {
            dgvMedidaPro.DataSource = logMedidaProducto.Instancia.ListarMedidaProducto();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                entMedidaProducto c = new entMedidaProducto();
                c.descripcion = txtDescripcion.Text;
                c.prefijo = txtPrefijo.Text;
                c.estado = chbxEstado.Checked;

                logMedidaProducto.Instancia.InsertarMedidaProducto(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }

            Limpiar();
            ListarMedida();
        }


        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                entMedidaProducto c = new entMedidaProducto();
                c.MedidaproductoID = int.Parse(txtId.Text.Trim());
                c.descripcion = txtDescripcion.Text.Trim();
                c.prefijo = txtPrefijo.Text.Trim();
                c.estado = chbxEstado.Checked;
                logMedidaProducto.Instancia.EditarMedidaProducto(c);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            Limpiar();
            gboxDatos.Enabled = false;
            ListarMedida();
            btnActualizar.Enabled = false;
        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            try
            {
                entMedidaProducto c = new entMedidaProducto();

                c.MedidaproductoID = int.Parse(txtId.Text.Trim());
                chbxEstado.Checked = false;
                c.estado = chbxEstado.Checked;
                logMedidaProducto.Instancia.DeshabilitarMedidaProducto(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            Limpiar();
            gboxDatos.Enabled = false;
            ListarMedida();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvMarcaPro_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvMedidaPro.Rows[e.RowIndex]; //
            txtId.Text = filaActual.Cells[0].Value.ToString();
            txtDescripcion.Text = filaActual.Cells[1].Value.ToString();
            txtPrefijo.Text = filaActual.Cells[2].Value.ToString();
            chbxEstado.Checked = Convert.ToBoolean(filaActual.Cells[3].Value);

            btnActualizar.Enabled = true;
            btnDeshabilitar.Enabled = true;
        }

    }
}

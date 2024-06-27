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
    public partial class FormMarcaProducto : Form
    {
        

        public FormMarcaProducto()
        {
            InitializeComponent();
            gbBotones.Enabled = false;
            dgvMarcaPro.Enabled = false;
            gboxDatos.Enabled = false;
            txtId.Enabled = false;
            ListarMarca();
            CambiarEncabezados();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            gbBotones.Enabled = true;
            dgvMarcaPro.Enabled = true;
            gboxDatos.Enabled = true;
            btnActualizar.Enabled = false;
            btnDeshabilitar.Enabled = false;
        }
        public void CambiarEncabezados()
        {
            dgvMarcaPro.Columns["MarcaproductoID"].HeaderText = "ID Marca";
            dgvMarcaPro.Columns["marca"].HeaderText = "Marca Producto";
            dgvMarcaPro.Columns["estado"].HeaderText = "Estado";
        }
        private void Limpiar()
        {
            txtId.Text = "";
            txtMarca.Text = "";
            chbxEstado.Checked = false;
        }

        private void dgvMarcaPro_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvMarcaPro.Rows[e.RowIndex]; //
            txtId.Text = filaActual.Cells[0].Value.ToString();
            txtMarca.Text = filaActual.Cells[1].Value.ToString();
            chbxEstado.Checked = Convert.ToBoolean(filaActual.Cells[2].Value);

            btnActualizar.Enabled = true;
            btnDeshabilitar.Enabled = true;

        }
        public void ListarMarca()
        {
            dgvMarcaPro.DataSource = logMarcaProducto.Instancia.ListarMarcaProducto();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                entMarcaProducto c = new entMarcaProducto();
                c.marca = txtMarca.Text;
                c.estado = chbxEstado.Checked;

                logMarcaProducto.Instancia.InsertarMarcaProducto(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }

            Limpiar();
            ListarMarca();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                entMarcaProducto c = new entMarcaProducto();
                c.MarcaproductoID = int.Parse(txtId.Text.Trim());
                c.marca = txtMarca.Text.Trim();
                c.estado = chbxEstado.Checked;
                logMarcaProducto.Instancia.EditaMarcaProducto(c);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            Limpiar();
            gboxDatos.Enabled = false;
            ListarMarca();
            btnActualizar.Enabled = false;
        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            try
            {
                entMarcaProducto c = new entMarcaProducto();

                c.MarcaproductoID = int.Parse(txtId.Text.Trim());
                chbxEstado.Checked = false;
                c.estado = chbxEstado.Checked;
                logMarcaProducto.Instancia.DeshabilitarMarcaProducto(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            Limpiar();
            gboxDatos.Enabled = false;
            ListarMarca();
        }
    }
}

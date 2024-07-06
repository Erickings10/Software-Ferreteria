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
    public partial class FormCategoriaProducto : Form
    {
        public FormCategoriaProducto()
        {
            InitializeComponent();
            gbBotones.Enabled = false;
            dgvCategoriaPro.Enabled = false;
            gboxDatos.Enabled = false;
            txtId.Enabled = false;
            ListarCategoria();
            CambiarEncabezados();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            gbBotones.Enabled = true;
            dgvCategoriaPro.Enabled = true;
            gboxDatos.Enabled = true;
            btnModificar.Enabled = false;
            btnDeshabilitar.Enabled = false;
        }
        public void CambiarEncabezados()
        {
            dgvCategoriaPro.Columns["CategoriaproductoID"].HeaderText = "ID Categoria";
            dgvCategoriaPro.Columns["descripcion"].HeaderText = "Descripción";
            dgvCategoriaPro.Columns["estado"].HeaderText = "Estado";
        }

        private void Limpiar()
        {
            txtId.Text = "";
            txtDescripcion.Text = "";
            chbxEstado.Checked = false;
        }

        private void dgvCategoriaPro_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvCategoriaPro.Rows[e.RowIndex]; //
            txtId.Text = filaActual.Cells[0].Value.ToString();
            txtDescripcion.Text = filaActual.Cells[1].Value.ToString();
            chbxEstado.Checked = Convert.ToBoolean(filaActual.Cells[2].Value);

            btnModificar.Enabled = true;
            btnDeshabilitar.Enabled = true;
        }

        public void ListarCategoria()
        {
            dgvCategoriaPro.DataSource = logCategoriaProductos.Instancia.ListarCategoriaProducto();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                entCategoriaProductos c = new entCategoriaProductos();
                c.descripcion = txtDescripcion.Text;
                c.estado = chbxEstado.Checked;

                logCategoriaProductos.Instancia.InsertaCategoriaProducto(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }

            Limpiar();
            ListarCategoria();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                entCategoriaProductos c = new entCategoriaProductos();
                c.CategoriaproductoID = int.Parse(txtId.Text.Trim());
                c.descripcion = txtDescripcion.Text.Trim();
                c.estado = chbxEstado.Checked;
                logCategoriaProductos.Instancia.EditaCategoriaProducto(c);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            Limpiar();
            gboxDatos.Enabled = false;
            ListarCategoria();
            btnModificar.Enabled = false;
        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            try
            {
                entCategoriaProductos c = new entCategoriaProductos();

                c.CategoriaproductoID = int.Parse(txtId.Text.Trim());
                chbxEstado.Checked = false;
                c.estado = chbxEstado.Checked;
                logCategoriaProductos.Instancia.DeshabilitaCategoriaProducto(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            Limpiar();
            gboxDatos.Enabled = false;
            ListarCategoria();
        }
    }
}

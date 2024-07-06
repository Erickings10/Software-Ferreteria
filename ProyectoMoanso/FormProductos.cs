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
            txtCodigo.Enabled = false;
            gboBotones1.Enabled = true;
            gbBotones2.Enabled = false;
            gboDatos.Enabled = false;
            dgvRegistroProducto.Enabled = false;
            cboMarca.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMedida.DropDownStyle = ComboBoxStyle.DropDownList;
            txtIdMarca.Visible = false;
            txtIdCategoria.Visible = false;
            txtIdMedida.Visible = false;
            listarProducto();
            CambiarEncabezados();
            listarMedida();
            listarCategoria(); 
            listarMarca ();
        }

        private void LimpiarVariables()
        {
            txtDescripcion.Text = "";
            cboMedida.Text = "";
            cboCategoria.Text = "";
            cboMedida.Text = "";
            txtDescripcion.Text = "";
            txtPrecioCompra.Text = "";
            txtPrecioVenta.Text = "";
            chbxEstado.Checked = false;

        }
        public void CambiarEncabezados()
        {
            dgvRegistroProducto.Columns["ProductoID"].HeaderText = "ID";
            dgvRegistroProducto.Columns["categoria"].HeaderText = "Categoria";
            dgvRegistroProducto.Columns["marca"].HeaderText = "Marca";
            dgvRegistroProducto.Columns["medida"].HeaderText = "Medida";
            dgvRegistroProducto.Columns["descripcion"].HeaderText = "Descripcion";
            dgvRegistroProducto.Columns["precioCompra"].HeaderText = "Precio de Compra";
            dgvRegistroProducto.Columns["precioVenta"].HeaderText = "Precio de Venta";
            dgvRegistroProducto.Columns["fecha"].HeaderText = "Fecha";
            dgvRegistroProducto.Columns["estado"].HeaderText = "Estado";
        }

        public void listarProducto()
        {
            dgvRegistroProducto.DataSource = logProductos.Instancia.ListarProductos();
        }

        private void btn_Guardar_Produc_Click(object sender, EventArgs e)
        {

            //insertar
            try
            {
                entProductos p = new entProductos();

                p.CategoriaproductoID = Convert.ToInt32(txtIdCategoria.Text);
                p.MarcaproductoID = Convert.ToInt32(txtIdMarca.Text);
                p.MedidaproductoID = Convert.ToInt32(txtIdMedida.Text);
                p.descripcion = txtDescripcion.Text;
                p.precioCompra = Convert.ToDecimal(txtPrecioCompra.Text);
                p.precioVenta = Convert.ToDecimal(txtPrecioVenta.Text);
                p.fecha = Convert.ToDateTime(dtPFecha.Text);
                p.estado = Convert.ToBoolean(chbxEstado.Checked);

                logProductos.Instancia.InsertaProductos(p);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }

            LimpiarVariables();
            listarProducto();
        }


        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            
            gboBotones1.Enabled = true;
            gbBotones2.Enabled = true;
            gboDatos.Enabled = true;
            dgvRegistroProducto.Enabled = true;
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            gboBotones1.Enabled = true;
            gbBotones2.Enabled = false;
            gboDatos.Enabled = false;
            dgvRegistroProducto.Enabled = false;
        }

        public void listarMedida()
        {
            cboMedida.DataSource = logMedidaProducto.Instancia.ListarReporteMedidaProducto();
            cboMedida.DisplayMember = "prefijo";
            cboMedida.ValueMember = "MedidaproductoID";
        }
        public void listarMarca()
        {
            cboMarca.DataSource = logMarcaProducto.Instancia.ListarReporteMarcaProducto();
            cboMarca.DisplayMember = "descripcion";
            cboMarca.ValueMember = "MarcaproductoID";
        }
        public void listarCategoria()
        {
            cboCategoria.DataSource = logCategoriaProductos.Instancia.ListarReporteCategoriaProducto();
            cboCategoria.DisplayMember = "descripcion";
            cboCategoria.ValueMember = "CategoriaproductoID";
        }
        private void AbrirMarca()
        {
            using (FormMarcaProducto frmMarca = new FormMarcaProducto())
            {
                if (frmMarca.ShowDialog() == DialogResult.OK)
                {
                    frmMarca.Show();
                }

            }
        }

        private void AbrirCategoria()
        {
            using (FormCategoriaProducto frmCategoria = new FormCategoriaProducto())
            {
                if (frmCategoria.ShowDialog() == DialogResult.OK)
                {
                    frmCategoria.Show();
                }

            }
        }
        private void AbrirMedidaProducto()
        {
            using (FormMedidaProducto frmMedida = new FormMedidaProducto())
            {
                if (frmMedida.ShowDialog() == DialogResult.OK)
                {
                    frmMedida.Show();
                }

            }
        }
        private void btnBuscarMarca_Click(object sender, EventArgs e)
        {
            AbrirMarca();
        }


        private void btnBuscarCategoria_Click(object sender, EventArgs e)
        {
            AbrirCategoria();
        }

        private void btnBuscarMedida_Click(object sender, EventArgs e)
        {
            AbrirMedidaProducto();
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                entProductos c = new entProductos();
                c.ProductoID = int.Parse(txtCodigo.Text.Trim());
                c.MarcaproductoID = int.Parse(txtIdMarca.Text.Trim());
                c.CategoriaproductoID = int.Parse(txtIdCategoria.Text.Trim());
                //c.descripcion = txtMarca.Text.Trim();
                c.estado = chbxEstado.Checked;
                //logProductos.Instancia.EditarProducto(c);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            gboDatos.Enabled = false;
            listarProducto();
            btnActualizar.Enabled = false;
        }

        private void dgvRegistroProducto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvRegistroProducto.Rows[e.RowIndex]; //
            txtCodigo.Text = filaActual.Cells[0].Value.ToString();
            cboMarca.Text = filaActual.Cells[1].Value.ToString();
            cboCategoria.Text = filaActual.Cells[2].Value.ToString();
            txtDescripcion.Text = filaActual.Cells[3].Value.ToString();
            chbxEstado.Checked = Convert.ToBoolean(filaActual.Cells[4].Value);

            btnActualizar.Enabled = true;
            btnDeshabilitar.Enabled = true;
        }


    }
}


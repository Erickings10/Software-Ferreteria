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
    public partial class FormRequerimientosdeCompras : Form
    {
        public FormRequerimientosdeCompras()
        {
            InitializeComponent();
            listarRequerimiento();
            gboRequerimientos.Enabled = false;
            txtCodigo.Enabled = false;
            gboBotones2.Enabled = false;
            btnCancelar.Enabled = false;    
        }

        private void CambiarEncabezados()
        {
            dgvRequerimientos.Columns["idRequer"].HeaderText = "ID de Requerimiento";
            dgvRequerimientos.Columns["prodRequer"].HeaderText = "Producto";
            dgvRequerimientos.Columns["fechaRequer"].HeaderText = "Fecha";
            dgvRequerimientos.Columns["cantRequer"].HeaderText = "Cantidad";
            dgvRequerimientos.Columns["marcaRequer"].HeaderText = "Marca";
            dgvRequerimientos.Columns["modelRequer"].HeaderText = "Modelo";
            dgvRequerimientos.Columns["estadRequer"].HeaderText = "Estado";
            dgvRequerimientos.Columns["priorRequer"].HeaderText = "Prioridad";
        }

        public void listarRequerimiento()
        {
            dgvRequerimientos.DataSource = logRequerimientos.Instancia.ListarRequerimientos();
            CambiarEncabezados();
        }

        private void btnNuevoRequerimiento_Click(object sender, EventArgs e)
        {
            gboRequerimientos.Enabled = true;
            gboBotones2.Enabled = true;
            btnCancelar.Enabled = true; 
        }

        private void dgvRequerimientos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvRequerimientos.Rows[e.RowIndex]; 
            txtCodigo.Text = filaActual.Cells[0].Value.ToString();
            txtProducto.Text = filaActual.Cells[1].Value.ToString();
            dtmReque.Value = Convert.ToDateTime(filaActual.Cells[2].Value);
            txtCantidad.Text = filaActual.Cells[3].Value.ToString();
            txt_marca.Text = filaActual.Cells[4].Value.ToString();
            txtModelo.Text = filaActual.Cells[5].Value.ToString();
            chboEstadoReque.Checked = Convert.ToBoolean(filaActual.Cells[6].Value);
            cbPrioridad.Text = filaActual.Cells[7].Value.ToString();

            btnNuevoReque.Enabled = false;
        }

        private void btnAgregaRequeri_Click(object sender, EventArgs e)
        {
            try
            {
                entRequerimiento c = new entRequerimiento();
                c.prodRequer = txtProducto.Text;
                c.fechaRequer = Convert.ToDateTime(dtmReque.Text);
                c.cantRequer = Convert.ToInt64(txtCantidad.Text);
                c.marcaRequer = txt_marca.Text;
                c.modelRequer = txtModelo.Text;
                c.estadRequer = chboEstadoReque.Checked;
                c.priorRequer = cbPrioridad.Text;
                logRequerimientos.Instancia.InsertaRequerimiento(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }

            Limpiar();
            listarRequerimiento();
        }

        private void btnDeshabilitarReque_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Estás seguro que desea anular el requerimiento?", "Confirmacion", MessageBoxButtons.YesNo);

            // Verificar la respuesta del usuario
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    entRequerimiento c = new entRequerimiento();

                    c.idRequer = int.Parse(txtCodigo.Text.Trim());
                    chboEstadoReque.Checked = false;
                    c.estadRequer = chboEstadoReque.Checked;
                    logRequerimientos.Instancia.DeshabilitarRequerimiento(c);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error.." + ex);
                }

                gboRequerimientos.Enabled = false;
                Limpiar();
                listarRequerimiento();
            }

        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            gboRequerimientos.Enabled = false;
            txtCodigo.Enabled = false;
            gboBotones2.Enabled = false;
            btnCancelar.Enabled = false;
        }

        private void Limpiar()
        {
            txtProducto.Text = "";
            txt_marca.Text = " ";
            txtCantidad.Text = " ";
            txtModelo.Text = " ";
        }
    }

}


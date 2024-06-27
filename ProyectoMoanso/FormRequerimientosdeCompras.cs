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
            dgvRequerimientos.Enabled = false;
        }

        public void listarRequerimiento()
        {
            dgvRequerimientos.DataSource = logRequerimientos.Instancia.ListarRequerimientos();
        }
        private void AbrirFormNuevoRequerimiento()
        {
            using (FormDetalleRequerimiento frmRequerimientoNuev = new FormDetalleRequerimiento())
            {
                if (frmRequerimientoNuev.ShowDialog() == DialogResult.OK)
                {
                    frmRequerimientoNuev.Show();

                }
            }
        }
        public void CambiarEncabezados()
        {
            dgvRequerimientos.Columns["id"].HeaderText = "ID de Requerimiento";
            dgvRequerimientos.Columns["producto"].HeaderText = "Producto";
            dgvRequerimientos.Columns["marca"].HeaderText = "Marca";
            dgvRequerimientos.Columns["categoria"].HeaderText = "Categoria";
            dgvRequerimientos.Columns["cantidad"].HeaderText = "Cantidad";
            dgvRequerimientos.Columns["fecha"].HeaderText = "Fecha";
            dgvRequerimientos.Columns["prioridad"].HeaderText = "Prioridad";
            dgvRequerimientos.Columns["estado"].HeaderText = "Estado";
        }

        private void btnNuevoRequerimiento_Click(object sender, EventArgs e)
        {
            AbrirFormNuevoRequerimiento();
            CambiarEncabezados();
        }


        private void btnDeshabilitarReque_Click(object sender, EventArgs e)
        {
            dgvRequerimientos.Enabled = true;
            /*DialogResult dialogResult = MessageBox.Show("¿Estás seguro que desea anular el requerimiento?", "Confirmacion", MessageBoxButtons.YesNo);

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
            }*/

        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            listarRequerimiento();
        }
    }

}


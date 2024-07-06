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
            CambiarEncabezados();
        }

        public void listarRequerimiento()
        {
            List<entRequerimiento> listaReq = logRequerimientos.Instancia.ListarRequerimientos();
            if (listaReq.Count >= 0)
            {
                dgvRequerimientos.Columns.Clear();
                dgvRequerimientos.DataSource = listaReq;
            }
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
            dgvRequerimientos.Columns["RequerimientoID"].HeaderText = "ID de Requerimiento";
            dgvRequerimientos.Columns["fecha"].HeaderText = "Fecha";
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
            
        }
    }

}


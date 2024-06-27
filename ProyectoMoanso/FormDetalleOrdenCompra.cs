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
    public partial class FormDetalleOrdenCompra : Form
    {
        public FormDetalleOrdenCompra()
        {
            InitializeComponent();
            txtRequerimiento.Enabled = false;
            txtCodigo.Enabled = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void AbrirReporteRequerimiento()
        {
            using (FormReporteRequerimiento frmReporteReq = new FormReporteRequerimiento())
            {
                if (frmReporteReq.ShowDialog() == DialogResult.OK)
                {
                    txtRequerimiento.Text = frmReporteReq.reporteRequerimiento;
                }
            }
        }

        private void btnBuscarRequerimiento_Click(object sender, EventArgs e)
        {
            AbrirReporteRequerimiento();
        }
    }
}

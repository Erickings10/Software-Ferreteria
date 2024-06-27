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
    public partial class FormReporteRequerimiento : Form
    {
        public string reporteRequerimiento {  get; set; }

        public FormReporteRequerimiento()
        {
            InitializeComponent();
            listarRequerimiento();
            
        }
        public void listarRequerimiento()
        {
            dgvReporteDetalle.DataSource = logRequerimientos.Instancia.ListarRequerimientos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvReporteRequerimiento_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvReporteDetalle.Rows[e.RowIndex];

            // Si el estado es true, asignar los valores
            reporteRequerimiento = filaActual.Cells[0].Value.ToString();


            DialogResult = DialogResult.OK;  // Esto cierra el formulario y devuelve el resultado a FormPrincipal
            Close();
        }
    }
}

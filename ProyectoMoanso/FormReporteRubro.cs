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
    public partial class FormReporteRubro : Form
    {
        public string nameRubro { get; private set; }
        public FormReporteRubro()
        {
            InitializeComponent();
            listarRubro();
        }
        private void Encabezados()
        {
            dgv_ReporteRubro.Columns["IDRubro"].HeaderText = "ID";
            dgv_ReporteRubro.Columns["Rubro"].HeaderText = "Rubro";
            dgv_ReporteRubro.Columns["FechaRub"].HeaderText = "Fecha de Registro";
            dgv_ReporteRubro.Columns["EstadoRub"].HeaderText = "Estado";
        }
        public void listarRubro() 
        {
            dgv_ReporteRubro.DataSource = logRubroProveedor.Instancia.ListarRubro();
            Encabezados();
        }

        private void dgv_ReporteRubro_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = dgv_ReporteRubro.Rows[e.RowIndex];

            nameRubro = fila.Cells[1].Value.ToString();
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

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
    public partial class FormReporteRubro : Form
    {
        public string nameRubro { get; private set; }
        public FormReporteRubro()
        {
            InitializeComponent();
            dgv_ReporteRubro.ReadOnly = true;
            listarRubro();
        }
        private void Encabezados()
        {
            dgv_ReporteRubro.Columns["idRubro"].HeaderText = "ID";
            dgv_ReporteRubro.Columns["nameRubro"].HeaderText = "Rubro";
            dgv_ReporteRubro.Columns["estRubro"].HeaderText = "Estado";
        }
        public void listarRubro() 
        {
            dgv_ReporteRubro.DataSource = logRubroProveedor.Instancia.ListarRubro();
            Encabezados();
        }

        private void dgv_ReporteRubro_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = dgv_ReporteRubro.Rows[e.RowIndex];

            nameRubro = fila.Cells[0].Value.ToString();
            DialogResult = DialogResult.OK;
            Close();
        }
        private void AbrirRubroProveedor()
        {
            using (FormRubroProveedor formRP = new FormRubroProveedor())
            {
                if (formRP.ShowDialog() == DialogResult.OK)
                {
                    formRP.Show();
                }

            }
        }
        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            AbrirRubroProveedor();
        }

        private void txtBuscaRub_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscaRub.Text != "")
            {
                entRubroProveedor r = new entRubroProveedor();
                r.nameRubro = txtBuscaRub.Text;
                DataTable dt = new DataTable();
                dt = logRubroProveedor.Instancia.BuscarRubro(r);
                dgv_ReporteRubro.DataSource = dt;
            }
            else 
            {
                dgv_ReporteRubro.DataSource = logRubroProveedor.Instancia.ListarRubro();
                Encabezados();
            }
        }

        private void FormReporteRubro_Load(object sender, EventArgs e)
        {
            dgv_ReporteRubro.AllowUserToAddRows = false;
        }
    }
}

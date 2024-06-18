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
    public partial class FormReporteProveedores : Form
    {
        public string sectorProve {  get; private set; }

        public FormReporteProveedores()
        {
            InitializeComponent();
            listarProveedores();
        }
        private void CambiarEncabezados()
        {
            dgvReporteProveedores.Columns["idProveedor"].HeaderText = "ID de Proveedor";
            dgvReporteProveedores.Columns["rucProveedor"].HeaderText = "Ruc de Proveedor";
            dgvReporteProveedores.Columns["ubiProv"].HeaderText = "Ubigeo";
            dgvReporteProveedores.Columns["sectorProve"].HeaderText = "Sector Comercial";
            dgvReporteProveedores.Columns["correoProv"].HeaderText = "Correo Electronico";
            dgvReporteProveedores.Columns["telfProv"].HeaderText = "Telefono";
            dgvReporteProveedores.Columns["estProv"].HeaderText = "Estado";
        }

        public void listarProveedores()
        {
            dgvReporteProveedores.DataSource = logProveedor.Instancia.ListarProveedor();
            CambiarEncabezados();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvReporteProveedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvReporteProveedores.Rows[e.RowIndex];

            // Si el estado es true, asignar los valores
            sectorProve = filaActual.Cells[0].Value.ToString();


            DialogResult = DialogResult.OK;  // Esto cierra el formulario y devuelve el resultado a FormPrincipal
            Close();
        }
    }
}

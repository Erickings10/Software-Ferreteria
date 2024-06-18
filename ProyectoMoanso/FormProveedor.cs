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
    public partial class FormProveedor : Form
    {
        public FormProveedor()
        {
            InitializeComponent();
            listarProveedores();
        }

        private void CambiarEncabezados()
        {
            dgvProveedores.Columns["idProveedor"].HeaderText = "ID de Proveedor";
            dgvProveedores.Columns["rucProveedor"].HeaderText = "Ruc de Proveedor";
            dgvProveedores.Columns["ubiProv"].HeaderText = "Ubigeo";
            dgvProveedores.Columns["sectorProve"].HeaderText = "Sector Comercial";
            dgvProveedores.Columns["correoProv"].HeaderText = "Correo Electronico";
            dgvProveedores.Columns["telfProv"].HeaderText = "Telefono";
            dgvProveedores.Columns["estProv"].HeaderText = "Estado";
        }

        public void listarProveedores()
        {
            dgvProveedores.DataSource = logProveedor.Instancia.ListarProveedor();
            CambiarEncabezados();
        }


        private void txt_nrodocu_pro_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txt_telefono_pro_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_agregar_pro_Click(object sender, EventArgs e)
        {
            try
            {
                entProveedor c = new entProveedor();
                c.rucProveedor = Convert.ToInt64(txtRucPro.Text);
                c.ubiProv = int.Parse(txtUbigeo.Text);
                c.sectorProve = txtSectorCome.Text;
                c.correoProv = txtCorreo.Text;
                c.telfProv = Convert.ToInt64(txtTelef.Text);
                c.estProv = chbEstado.Checked;
                logProveedor.Instancia.InsertaProveedor(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }


            listarProveedores();

        }
    }
}

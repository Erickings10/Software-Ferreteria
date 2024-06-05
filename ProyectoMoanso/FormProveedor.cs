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

            listarProveedors();
            
        }

        private void txtRazonSocial_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormProveedor_Load(object sender, EventArgs e)
        {


         


        }


        public void listarProveedors()
        {
            dgv_RegistroProveedor.DataSource = logProveedor.Instancia.ListaProveedores();
        }

        private void btn_Registrar_Click(object sender, EventArgs e)
        {


            //insertar
            try
            {
                entProveedor c = new entProveedor();
                c.Documento = txtNroDocumento.Text.Trim();
                c.RazonSocial = txtRazonSocial.Text.Trim();
                c.Correo = txtCorreo.Text.Trim();
                c.Telefono = txtTelefono.Text.Trim();
                c.Estado = chbxEstado.Checked;
                logProveedor.Instancia.InsertaProveedor(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            listarProveedors();
        }

        private void LimpiarVariables()
        {
            txtNroDocumento.Text = "";
            txtRazonSocial.Text = "";
            txtCorreo.Text = "";
            txtTelefono.Text = "";
            //cbkEstadoCliente.Checked = false;

        }











    }
}


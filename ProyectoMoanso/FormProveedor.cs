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
            txtIdProveedor.ReadOnly = true;
            listarProveedors();
            
        }


        public void listarProveedors()
        {
            dgv_RegistroProveedor.DataSource = logProveedor.Instancia.ListaProveedores();
        }

        private void btn_Registrar_Click(object sender, EventArgs e)
        {
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

        private void btn_Actualizar_Click(object sender, EventArgs e)
        {
            try
            {
                entProveedor p = new entProveedor();
                p.IdProveedor = int.Parse(txtIdProveedor.Text.Trim());
                p.Documento = txtNroDocumento.Text.Trim();
                p.RazonSocial = txtRazonSocial.Text.Trim();
                p.Correo = txtCorreo.Text.Trim();
                p.Telefono = txtTelefono.Text.Trim();
                p.Estado = chbxEstado.Checked;
                logProveedor.Instancia.ActualizaProveedor(p);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex+" ... ");
            }
            LimpiarVariables();
            listarProveedors();
        }

        private void dgv_RegistroProveedor_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = dgv_RegistroProveedor.Rows[e.RowIndex];
            txtIdProveedor.Text = fila.Cells[0].Value.ToString();
            txtNroDocumento.Text = fila.Cells[1].Value.ToString();
            txtRazonSocial.Text = fila.Cells[2].Value.ToString();
            txtCorreo.Text = fila.Cells[3].Value.ToString();
            txtTelefono.Text = fila.Cells[4].Value.ToString();
            chbxEstado.Checked = Convert.ToBoolean(fila.Cells[5].Value);
        }
    }
}


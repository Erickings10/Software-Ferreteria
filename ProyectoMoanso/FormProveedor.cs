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
            txtId.Enabled = false;
            gbox_Datos.Enabled = false;
            btn_agregar_pro.Enabled = false;
            btn_actualizar_pro.Enabled = false;
            btn_eliminar_pro.Enabled = false;
            dgvProveedores.ReadOnly = true;
        }

        private void CambiarEncabezados()
        {
            dgvProveedores.Columns["idProveedor"].HeaderText = "ID de Proveedor";
            dgvProveedores.Columns["rucProveedor"].HeaderText = "Ruc de Proveedor";
            dgvProveedores.Columns["ubiProv"].HeaderText = "Ubigeo";
            dgvProveedores.Columns["sectorProve"].HeaderText = "Sector Comercial";
            dgvProveedores.Columns["correoProv"].HeaderText = "Correo Electronico";
            dgvProveedores.Columns["telfProv"].HeaderText = "Telefono";
            dgvProveedores.Columns["fechaProv"].HeaderText = "Fecha de Registro";
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
        //------------------------------------------------------------------
        private void btn_agregar_pro_Click(object sender, EventArgs e)
        {
            try
            {
                entProveedor c = new entProveedor();
                c.rucProveedor = Convert.ToInt64(txtRucPro.Text);
                c.ubiProv = int.Parse(txtUbigeo.Text);
                c.sectorProve = int.Parse(txtSectorCome.Text);
                c.correoProv = txtCorreo.Text;
                c.telfProv = Convert.ToInt64(txtTelef.Text);
                c.fechaProv = datp_Fecha.Value;
                c.estProv = chbEstado.Checked;
                logProveedor.Instancia.InsertaProveedor(c);
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Limpiar();

            listarProveedores();
            btn_agregar_pro.Enabled = false;

        }
        private void btn_actualizar_pro_Click(object sender, EventArgs e)
        {
            try
            {
                entProveedor c = new entProveedor();
                c.idProveedor = int.Parse(txtId.Text.Trim());
                c.rucProveedor = Convert.ToInt64(txtRucPro.Text);
                c.ubiProv = int.Parse(txtUbigeo.Text);
                c.sectorProve = int.Parse(txtSectorCome.Text);
                c.correoProv = txtCorreo.Text;
                c.telfProv = Convert.ToInt64(txtTelef.Text);
                c.fechaProv = datp_Fecha.Value;
                c.estProv = chbEstado.Checked;
                logProveedor.Instancia.EditaProveedor(c);
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Limpiar();
            gbox_Datos.Enabled = false;
            listarProveedores();
            btn_actualizar_pro.Enabled = false;
        }
        private void btn_eliminar_pro_Click(object sender, EventArgs e)
        {
            try
            {
                entProveedor r = new entProveedor();
                r.idProveedor = int.Parse(txtId.Text.Trim());
                chbEstado.Checked = false;
                r.estProv = chbEstado.Checked;
                logProveedor.Instancia.DeshabilitarProveedor(r);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar" + ex);
            }
            Limpiar();
            gbox_Datos.Enabled = false;
            listarProveedores();
            btn_eliminar_pro.Enabled = false;
        }
        //--------------------------------------------------------------------------
        private void AbrirReporteRubro()
        {
            using (FormReporteRubro formRR = new FormReporteRubro())
            {
                formRR.ShowDialog();
                txtSectorCome.Text = formRR.nameRubro;
            }
        }

        private void btn_BuscarRubro_Click(object sender, EventArgs e)
        {
            AbrirReporteRubro();
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            gbox_Datos.Enabled = true;
            btn_agregar_pro.Enabled = true;
            btn_actualizar_pro.Enabled = false;
            btn_eliminar_pro.Enabled = false;
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            gbox_Datos.Enabled = true;
            btn_actualizar_pro.Enabled = true;
            btn_agregar_pro.Enabled = false;
            btn_eliminar_pro.Enabled = false;
        }

        private void btn_deshabilitar_Click(object sender, EventArgs e)
        {
            gbox_Datos.Enabled = true;
            btn_eliminar_pro.Enabled = true;
            btn_agregar_pro.Enabled = false;
            btn_actualizar_pro.Enabled = false;
        }

        private void dgvProveedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = dgvProveedores.Rows[e.RowIndex];
            txtId.Text = fila.Cells[0].Value.ToString();
            txtRucPro.Text = fila.Cells[1].Value.ToString();
            txtUbigeo.Text = fila.Cells[2].Value.ToString();
            txtSectorCome.Text = fila.Cells[3].Value.ToString();
            txtCorreo.Text = fila.Cells[4].Value.ToString();
            txtTelef.Text = fila.Cells[5].Value.ToString();
            datp_Fecha.Text = fila.Cells[6].Value.ToString();
            chbEstado.Checked = Convert.ToBoolean(fila.Cells[7].Value);
        }

        private void gbox_Datos_Enter(object sender, EventArgs e)
        {

        }
        private void Limpiar() 
        {
            txtRucPro.Text = " ";
            txtUbigeo.Text = " ";
            txtSectorCome.Text = " ";
            txtCorreo.Text = " ";
            txtTelef.Text= " ";
        }
    }
}

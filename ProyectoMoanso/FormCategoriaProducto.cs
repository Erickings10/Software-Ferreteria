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
    public partial class FormCategoriaProducto : Form
    {
        public FormCategoriaProducto()
        {
            InitializeComponent();

           btn_CancelarCT.Enabled = false;
           gbox_DatosCT.Enabled = false;
           txt_IDcp.Enabled = false;
           txt_IDcp.ReadOnly = true;
           gbox_BotonsCT.Enabled = false;

           listaCategoriaProducto();




        }


        private void Encabezados()
        {
            dgb_CategoriaProducto.Columns["IdCategoriaProducto"].HeaderText = "ID";
            dgb_CategoriaProducto.Columns["nombreCategoriaProducto"].HeaderText = "Categoria";
            dgb_CategoriaProducto.Columns["FechaRegistro"].HeaderText = "Fecha de Registro";
            dgb_CategoriaProducto.Columns["EstadoCategoriaProducto"].HeaderText = "Estado";
        }



        public void listaCategoriaProducto()
        {
            dgb_CategoriaProducto.DataSource = logCategoriaProductos.Instancia.ListarCategoriaProducto();
            Encabezados();
        }



        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btn_NuevoCT_Click(object sender, EventArgs e)
        {


            btn_CancelarCT.Enabled = true;
            gbox_DatosCT.Enabled = true;
            gbox_BotonsCT.Enabled = true;


        }

        private void btn_CancelarCT_Click(object sender, EventArgs e)
        {


            gbox_DatosCT.Enabled = false;
            txt_IDcp.Enabled = false;
            gbox_BotonsCT.Enabled = false;
            btn_CancelarCT.Enabled = false;


        }

        private void Limpiar()
        {
            txt_CategoriaCP.Text = "";
        }

        private void btn_agregarCT_Click(object sender, EventArgs e)
        {

            try
            {
                entCategoriaProductos cp = new entCategoriaProductos();
                cp.nombreCategoriaProducto = txt_CategoriaCP.Text.Trim();
                cp.FechaRegistro = datp_FechaCP.Value;
                cp.EstadoCategoriaProducto = chbx_EstadoCP.Checked;
                logCategoriaProductos.Instancia.InsertaCategoriaProducto(cp);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar" + ex);
            }
            Limpiar();
            gbox_DatosCT.Enabled = false;
            listaCategoriaProducto();


        }

        private void btn_actualizarCT_Click(object sender, EventArgs e)
        {

        }

        private void btn_ActualizarCT_Click(object sender, EventArgs e)
        {

            try
            {
                entCategoriaProductos cp = new entCategoriaProductos();
                cp.IdCategoriaProducto = int.Parse(txt_IDcp.Text.Trim());
                cp.nombreCategoriaProducto = txt_CategoriaCP.Text.Trim();
                cp.FechaRegistro = datp_FechaCP.Value;
                cp.EstadoCategoriaProducto = chbx_EstadoCP.Checked;
               logCategoriaProductos.Instancia.EditaCategoriaProducto(cp);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar" + ex);
            }
            Limpiar();
            gbox_DatosCT.Enabled = false;
            listaCategoriaProducto();





        }

        private void dgb_Categoria_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewRow fila = dgb_CategoriaProducto.Rows[e.RowIndex];
            txt_IDcp.Text = fila.Cells[0].Value.ToString();
            txt_CategoriaCP.Text = fila.Cells[1].Value.ToString();
            datp_FechaCP.Text = fila.Cells[2].Value.ToString();
            chbx_EstadoCP.Checked = Convert.ToBoolean(fila.Cells[3].Value);


        }

        private void btn_eliminarCT_Click(object sender, EventArgs e)
        {
            try
            {
                entCategoriaProductos cp = new entCategoriaProductos();
                cp.IdCategoriaProducto = int.Parse(txt_IDcp.Text.Trim());
                chbx_EstadoCP.Checked = false;
                cp.EstadoCategoriaProducto = chbx_EstadoCP.Checked;
                logCategoriaProductos.Instancia.DeshabilitaCategoriaProducto(cp);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar" + ex);
            }
            Limpiar();
            gbox_DatosCT.Enabled = false;
            listaCategoriaProducto();



        }
    }
}

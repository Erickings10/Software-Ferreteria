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
    public partial class FormRubroProveedor : Form
    {
        public FormRubroProveedor()
        {
            InitializeComponent();
            btn_Cancelar.Enabled = false;
            gbox_Datos.Enabled = false;
            txt_ID.Enabled = false;
            txt_ID.ReadOnly = true;
            gbox_Botons.Enabled = false;
            listaRubro();
        }
        private void Encabezados() 
        {
            dgb_Rubro.Columns["IDRubro"].HeaderText = "ID";
            dgb_Rubro.Columns["Rubro"].HeaderText = "Rubro";
            dgb_Rubro.Columns["FechaRub"].HeaderText = "Fecha de Registro";
            dgb_Rubro.Columns["EstadoRub"].HeaderText = "Estado";
        }
        public void listaRubro() 
        {
            dgb_Rubro.DataSource = logRubroProveedor.Instancia.ListarRubro();
            Encabezados();
        }
        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            btn_Cancelar.Enabled = true;
            gbox_Datos.Enabled=true;
            gbox_Botons.Enabled=true;
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            gbox_Datos.Enabled = false;
            txt_ID.Enabled=false;
            gbox_Botons.Enabled=false;
            btn_Cancelar.Enabled = false;
        }
        private void Limpiar()
        {
            txt_Rubro.Text = " ";
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            try 
            {
                entRubroProveedor rub = new entRubroProveedor();
                rub.nameRubro = txt_Rubro.Text.Trim();
                rub.fecRegistro = datp_Fecha.Value;
                rub.estRubro = chbx_Estado.Checked;
                logRubroProveedor.Instancia.InsertaRubro(rub);
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Error al agregar" + ex);
            }
            Limpiar();
            gbox_Datos.Enabled=false;
            listaRubro();
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            try
            {
                entRubroProveedor r = new entRubroProveedor();
                r.idRubro = int.Parse(txt_ID.Text.Trim());
                r.nameRubro = txt_Rubro.Text.Trim();
                r.fecRegistro= datp_Fecha.Value;
                r.estRubro = chbx_Estado.Checked;
                logRubroProveedor.Instancia.EditaRubro(r);
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Error al actualizar"+ex);
            }
            Limpiar();
            gbox_Datos.Enabled=false;
            listaRubro();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                entRubroProveedor r = new entRubroProveedor();
                r.idRubro = int.Parse(txt_ID.Text.Trim());
                chbx_Estado.Checked = false;
                r.estRubro = chbx_Estado.Checked;
                logRubroProveedor.Instancia.DeshabilitaRubro(r);
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Error al eliminar"+ex);
            }
            Limpiar();
            gbox_Datos.Enabled = false;
            listaRubro();
        }

        private void dgb_Rubro_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = dgb_Rubro.Rows[e.RowIndex];
            txt_ID.Text = fila.Cells[0].Value.ToString();
            txt_Rubro.Text = fila.Cells[1].Value.ToString();
            datp_Fecha.Text = fila.Cells[2].Value.ToString();
            chbx_Estado.Checked = Convert.ToBoolean(fila.Cells[3].Value);
        }
    }
}

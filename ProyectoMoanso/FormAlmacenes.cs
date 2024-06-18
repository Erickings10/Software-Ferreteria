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
    public partial class FormAlmacenes : Form
    {
        public FormAlmacenes()
        {
            InitializeComponent();
            ListarAlmacenes();
            gbInformacion.Enabled = false;
            txtId.Enabled = false;
            gbBotones2.Enabled = false;
            btnCancelar.Enabled = false;
        }

        public void ListarAlmacenes()
        {
            dgvAlmacenes.DataSource = logAlmacenes.Instancia.ListarAlmacenes();
            CambiarEncabezados();
        }
        private void CambiarEncabezados()
        {
            dgvAlmacenes.Columns["id"].HeaderText = "ID de Almacen";
            dgvAlmacenes.Columns["descripcion"].HeaderText = "Descripción";
            dgvAlmacenes.Columns["cantidad"].HeaderText = "Cantidad";
            dgvAlmacenes.Columns["tipo"].HeaderText = "Tipo";

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            gbInformacion.Enabled = true;
            gbBotones2.Enabled = true;
            btnCancelar.Enabled = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            gbInformacion.Enabled = false;
            txtId.Enabled = false;
            gbBotones2.Enabled = false;
            btnCancelar.Enabled = false;
        }

        private void Limpiar()
        {
            txtDescripcion.Text = "";
            txtTipo.Text = " ";
            txtCantidad.Text = " ";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                entAlmacenes c = new entAlmacenes();
                c.descripcion = txtDescripcion.Text;
                c.cantidad = Convert.ToInt64(txtCantidad.Text);
                c.tipo = txtTipo.Text;

                logAlmacenes.Instancia.InsertaAlmacenes(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }

            Limpiar();
            ListarAlmacenes();

        }
    }
}

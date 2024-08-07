﻿using CapaEntidad;
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
        private ErrorProvider errorcantidad;

        public FormAlmacenes()
        {
            InitializeComponent();
            this.errorcantidad = new ErrorProvider();
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

            dgvAlmacenes.Columns["AlmacenID"].HeaderText = "ID Almacen";
            dgvAlmacenes.Columns["descripcion"].HeaderText = "Descripción";
            dgvAlmacenes.Columns["cantidad"].HeaderText = "Cantidad";
            dgvAlmacenes.Columns["estado"].HeaderText = "Estado";

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {


            gbInformacion.Enabled = true;
            gbBotones2.Enabled = true;
            btnCancelar.Enabled = true;
            btnActualizar.Enabled = false;
            btnDeshabilitar.Enabled = false;

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
        }
        private void dgvAlmacenes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvAlmacenes.Rows[e.RowIndex]; //
            txtId.Text = filaActual.Cells[0].Value.ToString();
            txtDescripcion.Text = filaActual.Cells[1].Value.ToString();
            chbx_Estado.Checked = Convert.ToBoolean(filaActual.Cells[3].Value);

            btnActualizar.Enabled = true;
            btnDeshabilitar.Enabled = true;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                entAlmacenes c = new entAlmacenes();
                c.descripcion = txtDescripcion.Text;
                c.estado = Convert.ToBoolean(chbx_Estado.Checked);

                logAlmacenes.Instancia.InsertaAlmacenes(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }

            Limpiar();
            ListarAlmacenes();

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                entAlmacenes c = new entAlmacenes();
                c.AlmacenID = int.Parse(txtId.Text.Trim());
                c.descripcion = txtDescripcion.Text.Trim();
                c.estado = chbx_Estado.Checked;
                logAlmacenes.Instancia.EditarAlmacenes(c);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            Limpiar();
            gbInformacion.Enabled = false;
            ListarAlmacenes();
            btnActualizar.Enabled = false;
        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            try
            {
                entAlmacenes c = new entAlmacenes();

                c.AlmacenID = int.Parse(txtId.Text.Trim());
                chbx_Estado.Checked = false;
                c.estado = chbx_Estado.Checked;
                logAlmacenes.Instancia.DeshabilitarAlmacenes(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            Limpiar();
            gbInformacion.Enabled = false;
            ListarAlmacenes();
        }
    }
}

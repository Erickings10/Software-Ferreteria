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
    public partial class FormBuscarProducto : Form
    {
        public string descripcion { get; private set; }
        public string Id { get; private set; }
        public string PrecioU { get; private set; }
        public string stock { get; private set; }
        public FormBuscarProducto()
        {
            InitializeComponent();
            ListaAlmacen();
        }

        public void ListaAlmacen()
        {
            dgvProducto.DataSource = logAlmacenes.Instancia.ListarAlmacenes();
        }
        private void iconButton2_Click(object sender, EventArgs e)
        {

        }

        private void dgvProducto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvProducto.Rows[e.RowIndex];

                Id = fila.Cells[0].Value.ToString();
                descripcion = fila.Cells[5].Value.ToString();
                PrecioU = fila.Cells[4].Value.ToString();
                stock = fila.Cells[2].Value.ToString();
                DialogResult = DialogResult.OK;
                Close();
            }

        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

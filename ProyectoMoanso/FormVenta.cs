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
    public partial class FormVenta : Form
    {
        ApisPeru AP = new ApisPeru();
        public FormVenta()
        {
            InitializeComponent();
            cbmMetodoP.Items.Add("Yape");
            cbmMetodoP.Items.Add("Plin");
            cbmMetodoP.Items.Add("Efectivo");
            cbmTipoDoc.Items.Add("Boleta");
            cbmTipoDoc.Items.Add("Factura");

            cbmTipoDoc.Enabled = false;
            txtDocumento.Enabled = false;
            btnBuscarD.Enabled = false;
            txtNombreC.Enabled = false;
            txtNombreC.Enabled = false;

            txtID.Enabled = false;

            txtProducto.Enabled = false;
            btnBuscarP.Enabled = false;
            txtPrecioU.Enabled = false;
            txtCantidad.Enabled = false;
            cbmMetodoP.Enabled = false;

        }


        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscarD_Click(object sender, EventArgs e)
        {
            consultar();

        }
        private void consultar()
        {
            try
            {
                //---------DNI-----------
                if (txtDocumento.Text.Length == 8)
                {
                    dynamic respuesta = AP.Get("https://dniruc.apisperu.com/api/v1/dni/" + txtDocumento.Text + "?token=eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJlbWFpbCI6Im11bm96cm9uY2FsZGF2aWRhZHJpYW5AZ21haWwuY29tIn0.1Ns7hkbfA5yAWkne3Af8oYqLr7JQXYwormyuoRo7obY");
                    txtNombreC.Text = respuesta.nombres.ToString() + " " + respuesta.apellidoPaterno.ToString();
                }
                else
                {
                    MessageBox.Show("No se encontraron datos para el número de documento proporcionado.");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error... " + ex.Message);
            }
        }

        private void btnBuscarP_Click(object sender, EventArgs e)
        {
            using (FormBuscarProducto formP = new FormBuscarProducto())
            {
                if (formP.ShowDialog() == DialogResult.OK)
                {
                    txtID.Text = formP.Id;
                    txtProducto.Text = formP.descripcion;
                    txtPrecioU.Text = formP.PrecioU;
                    stockDisponible = Convert.ToInt32(formP.stock);
                }

            }
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            if (dgvSeleccion.Rows.Count < 1)
            {
                MessageBox.Show("No se selecionó ningun producto.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            int cantidadTotal = 0, unidades = 0;
            decimal montoUnidad = 0, montoTotal = 0;
            entVenta c = new entVenta();
            c.medPago = cbmMetodoP.Text.ToString();
            c.numDoc = Convert.ToInt64(txtDocumento.Text.ToString());
            c.nombreCli = txtNombreC.Text.ToString();
            foreach (DataGridViewRow fila in dgvSeleccion.Rows)
            {
                cantidadTotal += int.Parse(fila.Cells[4].Value?.ToString());
            }
            c.cantidad = cantidadTotal;
            cantidadTotal = 0;
            foreach (DataGridViewRow fila in dgvSeleccion.Rows)
            {
                unidades = int.Parse(fila.Cells[4].Value?.ToString());
                montoUnidad = Decimal.Parse(fila.Cells[3].Value?.ToString());
                montoTotal += (Decimal.Parse(unidades.ToString()) * montoUnidad);
            }
            c.montoTotal = montoTotal;

            DateTime d = DateTime.Now;
            c.fecharegistro = d.Date;

            // Llamada a InsertarVenta de logVenta.Instancia
            if (logVenta.Instancia.InsertarVenta(ref c))
            {
                // Iterar sobre las filas de dgvSeleccion para insertar detalles de la venta
                foreach (DataGridViewRow fila in dgvSeleccion.Rows)
                {
                    entDetalleVenta vo = new entDetalleVenta();
                    vo.OrdenVentaID = c.OrdenVentaID;
                    int idInv = int.Parse(fila.Cells[1].Value?.ToString());
                    vo.AlmacenID = idInv;
                    int cantidad = int.Parse(fila.Cells[4].Value?.ToString());
                    vo.cantidad = cantidad;
                    decimal precioUnitario = decimal.Parse(fila.Cells[3].Value?.ToString());
                    vo.precioVenta = precioUnitario;
                    decimal subTotal = cantidad * precioUnitario;
                    vo.Total = subTotal;
                    logDetalleVenta.Instancia.InsertarDetVenta(vo);
                }

                // Mostrar mensaje de confirmación de ingreso de datos
                MessageBox.Show("Ingreso correcto de datos. ID de venta: " + c.OrdenVentaID, "CONFIRMACION INGRESO", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Error al insertar la venta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dgvSeleccion.Rows.Clear();

            txtNombreC.Text = "";
            txtCantidad.Text = "";
            txtDocumento.Text = "";
            txtPrecioU.Text = "";
            txtID.Text = "";
            txtProducto.Text = "";
            lblTotal.Text = "--";
            cbmMetodoP.Text = "";
            cbmTipoDoc.Text = "";
        }

        private int stockDisponible;
        private int idTemporal = 1;
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Verifica si el campo de cantidad está vacío o no es un número válido
            if (!int.TryParse(txtCantidad.Text, out int cantidad))
            {
                MessageBox.Show("Por favor, ingrese una cantidad válida.", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Verifica si la cantidad es mayor al stock disponible
            if (cantidad > stockDisponible)
            {
                MessageBox.Show("La cantidad solicitada es mayor al stock.", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCantidad.Text = "";
                txtID.Text = "";
                txtProducto.Text = "";
                txtPrecioU.Text = "";
                return;
            }

            // Verifica si los campos de texto están llenos
            if (string.IsNullOrEmpty(txtID.Text) ||
                string.IsNullOrEmpty(txtProducto.Text) ||
                string.IsNullOrEmpty(txtPrecioU.Text))
            {
                MessageBox.Show("Seleccione un producto válido.", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Crea un nuevo objeto de inventario
            entAlmacenes c = new entAlmacenes
            {
                AlmacenID = Convert.ToInt32(txtID.Text),
                descripcion = txtProducto.Text,
                cantidad = cantidad,
                PrecioVenta = Convert.ToDecimal(txtPrecioU.Text)
            };

            // Agrega el objeto al DataGridView de selección
            dgvSeleccion.Rows.Add(idTemporal, c.AlmacenID, c.descripcion, c.PrecioVenta, c.cantidad);

            // Incrementar el contador de ID temporal para la próxima fila
            idTemporal++;

            // Limpia los campos de texto
            txtCantidad.Text = "";
            txtID.Text = "";
            txtProducto.Text = "";
            txtPrecioU.Text = "";

            // Calcular y mostrar el total
            CalcularTotal();
        }
        private void CalcularTotal()
        {
            decimal total = 0;

            foreach (DataGridViewRow row in dgvSeleccion.Rows)
            {
                if (row.Cells["columnPVenta"].Value != null && row.Cells["columnCan"].Value != null)
                {
                    decimal precioVenta = Convert.ToDecimal(row.Cells["columnPVenta"].Value);
                    int cantidad = Convert.ToInt32(row.Cells["columnCan"].Value);
                    total += precioVenta * cantidad;
                }
            }

            lblTotal.Text = total.ToString("C2");
        }
        private void gbxInformacionVen_Enter(object sender, EventArgs e)
        {

        }

        private void gbxInformacionCli_Enter(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            cbmTipoDoc.Enabled = true;
            txtDocumento.Enabled = true;
            btnBuscarD.Enabled = true;
            txtNombreC.Enabled = true;
            txtNombreC.Enabled = true;
            btnBuscarP.Enabled = true;
            txtCantidad.Enabled = true;
            cbmMetodoP.Enabled = true;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (dgvSeleccion.SelectedRows.Count > 0)
            {
                dgvSeleccion.Rows.RemoveAt(dgvSeleccion.SelectedRows[0].Index);
            }
            CalcularTotal();
        }

        private void txtNombreC_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDocumento_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtProducto_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

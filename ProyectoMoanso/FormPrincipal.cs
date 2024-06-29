using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoMoanso
{
    public partial class FormPrincipal : System.Windows.Forms.Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }



        private void AbrirFormulario(IconMenuItem menu, Form formulario)
        {


        }



        private void menuProveedores_Click(object sender, EventArgs e)
        {
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        private void panelTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
            btnMaximizar.Visible = true;
        }

        private void AbrirFormularios(object formMenor)
        {
            if (this.contenedor.Controls.Count > 0)
            {
                this.contenedor.Controls.RemoveAt(0);
            }  
            Form formulario = formMenor as Form;
            formulario.TopLevel = false;
            formulario.Dock = DockStyle.Fill;
            this.contenedor.Controls.Add(formulario);
            this.contenedor.Tag = formulario;
            formulario.Show();
        }

        private void btnOrdenCompra_Click(object sender, EventArgs e)
        {
            AbrirFormularios(new dgv_productosRequeridos());
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            AbrirFormularios(new FormProductos());
        }

        private void btnProovedores_Click(object sender, EventArgs e)
        {
            AbrirFormularios(new FormProveedor());
        }

        private void btnAlmacen_Click(object sender, EventArgs e)
        {
            AbrirFormularios(new FormEntradaProductos());
        }

        private void btnPagoFacturas_Click(object sender, EventArgs e)
        {
            AbrirFormularios(new FormPagoFactura());
        }

        private void btnNecesidad_Click(object sender, EventArgs e)
        {
            AbrirFormularios(new FormRequerimientosdeCompras());
        }

        private void btnDevolucion_Click(object sender, EventArgs e)
        {
            AbrirFormularios(new FormSalidaProductos());
        }

        private void btnAlmacenes_Click(object sender, EventArgs e)
        {

            AbrirFormularios(new FormAlmacenes());
        }

        private void panelTitulo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCategoriaProducto_Click(object sender, EventArgs e)
        {

            AbrirFormularios(new FormCategoriaProducto());

        }
    }
}

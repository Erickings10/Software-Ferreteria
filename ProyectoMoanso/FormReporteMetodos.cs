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
   

    public partial class FormReporteMetodos : Form
    {
        public string metodo { get; set; }

        public FormReporteMetodos()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void AbrirFormMetodoPago()
        {
            using (FormMetodoPago frmMetodoPago = new FormMetodoPago())
            {
                if (frmMetodoPago.ShowDialog() == DialogResult.OK)
                {
                    frmMetodoPago.Show();


                }
            }
        }

        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            AbrirFormMetodoPago();
        }
    }
}

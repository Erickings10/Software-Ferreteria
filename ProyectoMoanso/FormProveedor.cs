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
            txt_Codi_pro.ReadOnly= true;
        }

        private void txt_nrodocu_pro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) 
            {
                e.Handled = true;
                errorDocumento.SetError(txt_nrodocu_pro, "Ingrese solo numeros");
            }
            else 
            {
                errorDocumento.SetError(txt_nrodocu_pro, "");
            }
        }

        private void txt_telefono_pro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) 
            {
                e.Handled= true;
                errorTelefono.SetError(txt_telefono_pro,"Ingrese solo numeros");
            }
            else 
            {
                errorTelefono.SetError(txt_telefono_pro, "");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

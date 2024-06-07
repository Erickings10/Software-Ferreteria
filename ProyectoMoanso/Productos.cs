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
    public partial class Productos : Form
    {
        public Productos()
        {
            InitializeComponent();
            txt_codigo_produc.ReadOnly = true;
        }

        private void txt_stock_produc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) 
            {
                e.Handled = true;
                errorStock.SetError(txt_stock_produc, "Solo ingrese numeros");
            }
            else 
            {
                errorStock.SetError(txt_stock_produc,"");
            }
        }

        private void Productos_Load(object sender, EventArgs e)
        {

        }
    }
}

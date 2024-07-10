using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entOrdendeCompra
    {
        public int OrdencompraID { get; set; }
        public int PagoordencompraID { get; set; }
        public int ProveedorID { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Total { get; set; }
        public bool Estado { get; set; }
    }
}

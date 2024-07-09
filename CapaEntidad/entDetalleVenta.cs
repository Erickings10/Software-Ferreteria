using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entDetalleVenta
    {
        public int DetalleVentaID { get; set; }
        public int OrdenVentaID { get; set; }
        public int AlmacenID { get; set; }
        public string descripcion { get; set; }
        public int cantidad { get; set; }
        public decimal precioVenta { get; set; }
        public decimal Total { get; set; }
    }
}

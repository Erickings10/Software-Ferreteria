using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entVenta
    {
        public int OrdenVentaID { get; set; }
        public Int64 numDoc { get; set; }
        public string nombreCli { get; set; }
        public string medPago { get; set; }
        public int cantidad { get; set; }
        public decimal montoTotal { get; set; }
        public DateTime fecharegistro { get; set; }
    }
}

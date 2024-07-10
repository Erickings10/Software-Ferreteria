using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entAlmacenes
    {
        public int AlmacenID { get; set; }
        public string descripcion { get; set; }
        public int cantidad { get; set; }
        public Boolean estado { get; set; }
        public decimal PrecioVenta { get; set; }
        public string desPro { get; set; }
    }
}

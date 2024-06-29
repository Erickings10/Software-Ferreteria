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
        public Int64 cantidad { get; set; }
        public string tipo { get; set; }
        public Boolean estado { get; set; }

    }
}

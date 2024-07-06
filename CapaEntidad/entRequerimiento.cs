using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entRequerimiento
    {
        public int RequerimientoID {  get; set; }

        public DateTime fecha {  get; set; }

        public Boolean estado { get; set; }

        public List<entDetRequerimiento> DetRequerimientos { get; set; }

    }
}

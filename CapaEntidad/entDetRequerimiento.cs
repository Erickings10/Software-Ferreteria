using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entDetRequerimiento
    {
        public int DetallerequerimientoID {  get; set; }

        public entProductos ProductoID { get; set; }

        public int RequerimientoID { get; set; }

        public int cantidad {  get; set; }

        public string prioridad { get; set; }
    }
}

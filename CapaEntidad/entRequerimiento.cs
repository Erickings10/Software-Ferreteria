using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entRequerimiento
    {
        public int id { get; set; }
        public string producto { get; set; }
        public string marca { get; set; }
        public string categoria { get; set; }
        public Int64 cantidad { get; set; }
        public DateTime fecha { get; set; }
        public string prioridad { get; set; }
        public Boolean estado { get; set; }

    }
}

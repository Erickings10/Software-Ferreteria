using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entProveedor
    {
        public int idProveedor { get; set; }
        public Int64 rucProveedor { get; set; }
        public int ubiProv { get; set; }
        public int sectorProve { get; set; }
        public string correoProv { get; set; }      
        public Int64 telfProv { get; set; }
        public DateTime fechaProv { get; set; }
        public Boolean estProv { get; set; }

    }
}

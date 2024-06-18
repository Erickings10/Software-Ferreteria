using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entRequerimiento
    {
        public int idRequer { get; set; }
        public string prodRequer { get; set; }
        public DateTime fechaRequer { get; set; }
        public Int64 cantRequer { get; set; }
        public string marcaRequer { get; set; }
        public string modelRequer { get; set; }
        public Boolean estadRequer { get; set; }
        public string priorRequer { get; set; }

    }
}

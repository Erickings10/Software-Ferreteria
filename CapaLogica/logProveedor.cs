using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logProveedor
    {
        private static readonly logProveedor _instancia = new logProveedor();
        public static logProveedor Instancia 
        {
            get 
            {
                return logProveedor._instancia;
            }
        }
    }
}

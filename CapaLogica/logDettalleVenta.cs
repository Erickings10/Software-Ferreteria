using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logDetalleVenta
    {
        #region singleton

        private static readonly logDetalleVenta _instancia = new logDetalleVenta();
        public static logDetalleVenta Instancia
        {
            get
            {
                return logDetalleVenta._instancia;
            }
        }

        #endregion singleton

        public bool InsertarDetVenta(entDetalleVenta detVenta)
        {
            return datDetalleVenta.Instancia.InsertarDetVenta(detVenta);
        }
    }
}

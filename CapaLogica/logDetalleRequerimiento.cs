using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logDetalleRequerimiento
    {
        #region singleton

        private static readonly logDetalleRequerimiento _instancia = new logDetalleRequerimiento();
        public static logDetalleRequerimiento Instancia
        {
            get
            {
                return logDetalleRequerimiento._instancia;
            }
        }

        #endregion singleton

        public bool InsertarDetalleRequerimietno(entDetalleRequerimiento detReq)
        {
            return datDetalleRequerimiento.Instancia.InsertarDetRequerimiento(detReq);
        }
    }
}

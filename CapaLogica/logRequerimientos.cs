using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logRequerimientos
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logRequerimientos _instancia = new logRequerimientos();
        //privado para evitar la instanciación directa
        public static logRequerimientos Instancia
        {
            get
            {
                return logRequerimientos._instancia;
            }
        }
        #endregion singleton

        #region metodos

        ///listado

        public List<entRequerimiento> ListarRequerimientos()
        {
            return datRequerimientos.Instancia.ListarRequerimiento();

        }

        public void InsertaRequerimiento(entRequerimiento Req)
        {
            datRequerimientos.Instancia.InsertarRequerimiento(Req);
        }
        public void DeshabilitarRequerimiento(entRequerimiento Req)
        {
            datRequerimientos.Instancia.DeshabilitarRequerimiento(Req);
        }

        #endregion metodos
    }
}

using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logOrdendeCompra
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logOrdendeCompra _instancia = new logOrdendeCompra();
        //privado para evitar la instanciación directa
        public static logOrdendeCompra Instancia
        {
            get
            {
                return logOrdendeCompra._instancia;
            }
        }
        #endregion singleton

        #region metodos

        public List<entOrdendeCompra> ListarOrdenCompra()
        {
            return datOrdendeCompra.Instancia.ListarOrdenDeCompra();
        }

        public void InsertaOrdenCompra(entOrdendeCompra orden)
        {
            datOrdendeCompra.Instancia.InsertarOrdenCompra(orden);
        }

        public void DeshabilitarOrdenCompra(entOrdendeCompra orden)
        {
            datOrdendeCompra.Instancia.DeshabilitarOrdenCompra(orden);
        }
        #endregion metodos
    }
}

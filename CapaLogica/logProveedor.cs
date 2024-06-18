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
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logProveedor _instancia = new logProveedor();
        //privado para evitar la instanciación directa
        public static logProveedor Instancia
        {
            get
            {
                return logProveedor._instancia;
            }
        }
        #endregion singleton

        #region metodos

        ///listado
        
        public List<entProveedor> ListarProveedor()
        {
            return datProveedor.Instancia.ListarProveedor();

        }

        public void InsertaProveedor(entProveedor Pro)
        {
            datProveedor.Instancia.InsertarProveedor(Pro);
        }

        #endregion metodos


    }
}

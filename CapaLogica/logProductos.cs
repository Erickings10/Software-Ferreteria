using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logProductos
    {

        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logProductos _instancia = new logProductos();
        //privado para evitar la instanciación directa
        public static logProductos Instancia
        {
            get
            {
                return logProductos._instancia;
            }
        }

        #endregion singleton


        #region metodos

        public List<entProductos> ListarProductos()
        {
            return datProductos.Instancia.ListarProductos();

        }



        public void InsertaProductos(entProductos Prod)
        {
            datProductos.Instancia.InsertarProductos(Prod);
        }

        #endregion metodos










    }
}

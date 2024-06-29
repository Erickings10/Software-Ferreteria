using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logEntradaProductos
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logEntradaProductos _instancia = new logEntradaProductos();
        //privado para evitar la instanciación directa
        public static logEntradaProductos Instancia
        {
            get
            {
                return logEntradaProductos._instancia;
            }
        }

        #endregion singleton


        #region metodos

        public List<entEntradaProductos> ListarEntradaProducto()
        {
            return datEntradaProductos.Instancia.ListarEntradaProductos();

        }

        public void InsertarEntradaProducto(entEntradaProductos Ent)
        {
            datEntradaProductos.Instancia.InsertarEntradaProducto(Ent);
        }



        #endregion metodos

    }
}

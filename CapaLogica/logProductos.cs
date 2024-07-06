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
        

        public List<entDescProducto> ListarProductos()
        {
            return datProductos.Instancia.ListarProductos();

        }

        public void InsertaProductos(entProductos Prod)
        {
            datProductos.Instancia.InsertarProductos(Prod);
        }

        /*public void EditarProducto(entProductos pro) 
        { 
            datProductos.Instancia.EditarProducto(pro);
            
        }*/
        public List<entDescProducto> ListarReporteProducto()
        {
            return datProductos.Instancia.ListarReporteProducto();
        }
        public entProductos BuscarProductoId(int idProducto)
        {
            try
            {
                return datProductos.Instancia.BuscarProductoId(idProducto);
            }
            catch (Exception e) { throw e; }
        }


        #endregion metodos










    }
}

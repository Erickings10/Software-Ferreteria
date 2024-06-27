using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logCategoriaProductos
    {


        #region sigleton

        private static readonly logCategoriaProductos _instancia = new logCategoriaProductos();
        public static logCategoriaProductos Instancia
        {
            get
            {
                return logCategoriaProductos._instancia;
            }
        }
        #endregion singleton


        #region metodos

        public List<entCategoriaProductos> ListarCategoriaProducto()
        {
            return datCategoriaProductos.Instancia.ListarCategoriaProducto();
        }


        public void InsertaCategoriaProducto(entCategoriaProductos cp)
        {
            datCategoriaProductos.Instancia.InsertaCategoriaProducto(cp);
        }

        public void EditaCategoriaProducto(entCategoriaProductos cp)
        {
            datCategoriaProductos.Instancia.EditaCategoriaProducto(cp);

        }

        public void DeshabilitaCategoriaProducto(entCategoriaProductos cp)
        {
            datCategoriaProductos.Instancia.DeshabilitarCategoriaProducto(cp);
        }

        public List<entCategoriaProductos> ListarReporteCategoriaProducto()
        {
            return datCategoriaProductos.Instancia.ListarReporteCategoriaProducto();


        }

        #endregion metodos
    }
}
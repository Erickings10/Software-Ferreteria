using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logMarcaProducto
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logMarcaProducto _instancia = new logMarcaProducto();
        //privado para evitar la instanciación directa
        public static logMarcaProducto Instancia
        {
            get
            {
                return logMarcaProducto._instancia;
            }
        }

        #endregion singleton

        #region metodos

        public List<entMarcaProducto> ListarMarcaProducto()
        {
            return datMarcaProducto.Instancia.ListarMarcaProducto();

        }
        public void InsertarMarcaProducto(entMarcaProducto Mar)
        {
            datMarcaProducto.Instancia.InsertarMarca(Mar);
        }
        public void EditaMarcaProducto(entMarcaProducto Mar)
        {
            datMarcaProducto.Instancia.EditarMarca(Mar);
        }
        public void DeshabilitarMarcaProducto(entMarcaProducto Mar)
        {
            datMarcaProducto.Instancia.DeshabilitarMarca(Mar);
        }
        public List<entMarcaProducto> ListarReporteMarcaProducto()
        {
            return datMarcaProducto.Instancia.ListarReporteMarcaProducto();

        }

        #endregion metodos
    }
}

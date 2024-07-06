using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logMedidaProducto
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logMedidaProducto _instancia = new logMedidaProducto();
        //privado para evitar la instanciación directa
        public static logMedidaProducto Instancia
        {
            get
            {
                return logMedidaProducto._instancia;
            }
        }

        #endregion singleton

        #region metodos

        public List<entMedidaProducto> ListarMedidaProducto()
        {
            return datMedidaProducto.Instancia.ListarMedidaProducto();

        }
        public List<entMedidaProducto> ListarReporteMedidaProducto()
        {
            return datMedidaProducto.Instancia.ListarReporteMedidaProducto();

        }

        public void InsertarMedidaProducto(entMedidaProducto Med)
        {
            datMedidaProducto.Instancia.InsertarMedida(Med);
        }
        public void EditarMedidaProducto(entMedidaProducto Med)
        {
            datMedidaProducto.Instancia.EditarMedida(Med);
        }
        public void DeshabilitarMedidaProducto(entMedidaProducto Med)
        {
            datMedidaProducto.Instancia.DeshabilitarMedida(Med);
        }

        #endregion metodos
    }
}

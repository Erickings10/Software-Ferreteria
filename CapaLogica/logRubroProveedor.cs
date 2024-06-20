using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logRubroProveedor
    {
        #region sigleton

        private static readonly logRubroProveedor _instancia = new logRubroProveedor();
        public static logRubroProveedor Instancia
        {
            get
            {
                return logRubroProveedor._instancia;
            }
        }
        #endregion singleton

        #region metodos

        public List<entRubroProveedor> ListarRubro() 
        {
            return datRubroProveedor.Instancia.ListarRubro();
        }
        public void InsertaRubro(entRubroProveedor Rub) 
        {
            datRubroProveedor.Instancia.InsertaRubro(Rub);
        }
        public void EditaRubro(entRubroProveedor Rub) 
        {
            datRubroProveedor.Instancia.EditaRubro(Rub);
        }
        public void DeshabilitaRubro(entRubroProveedor Rub) 
        {
            datRubroProveedor.Instancia.DeshabilitarRubro(Rub);
        }

        #endregion metodos
    }
}

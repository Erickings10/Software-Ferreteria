using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class datDetalleRequerimiento
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly datDetalleRequerimiento _instancia = new datDetalleRequerimiento();
        //privado para evitar la instanciación directa
        public static datDetalleRequerimiento Instancia
        {
            get
            {
                return datDetalleRequerimiento._instancia;
            }
        }
        #endregion singleton


        public Boolean InsertarDetRequerimiento(entDetalleRequerimiento detReq)
        {
            SqlCommand cmd = null;
            Boolean insertado = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarDetalleRequerimiento", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@RequerimientoID", detReq.RequerimientoID);
                cmd.Parameters.AddWithValue("@ProductoID", detReq.ProductoID);
                cmd.Parameters.AddWithValue("@cantidad", detReq.cantidad);
                cmd.Parameters.AddWithValue("@prioridad", detReq.prioridad);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    insertado = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return insertado;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;

namespace CapaDatos
{
    public class datDetalleVenta
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly datDetalleVenta _instancia = new datDetalleVenta();
        //privado para evitar la instanciación directa
        public static datDetalleVenta Instancia
        {
            get
            {
                return datDetalleVenta._instancia;
            }
        }
        #endregion singleton
        public Boolean RestarStock(int id, int cant)
        {
            SqlCommand cmd = null;
            Boolean insertado = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spRestarStock", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idAlm", id);
                cmd.Parameters.AddWithValue("@cant", cant);
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
        public Boolean InsertarDetVenta(entDetalleVenta detVenta)
        {
            SqlCommand cmd = null;
            Boolean insertado = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarDetalleVenta", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@OrdenVentaID", detVenta.OrdenVentaID);
                cmd.Parameters.AddWithValue("@AlmacenID", detVenta.AlmacenID);
                cmd.Parameters.AddWithValue("@cantidad", detVenta.cantidad);
                cmd.Parameters.AddWithValue("@PrecioVenta", detVenta.precioVenta);
                cmd.Parameters.AddWithValue("@Total", detVenta.Total);
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
                RestarStock(detVenta.AlmacenID, detVenta.cantidad);
            }
            return insertado;
        }
    }
}

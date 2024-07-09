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
    public class datVenta
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly datVenta _instancia = new datVenta();
        //privado para evitar la instanciación directa
        public static datVenta Instancia
        {
            get
            {
                return datVenta._instancia;
            }
        }
        #endregion singleton
        public Boolean InsertarVenta(ref entVenta venta)
        {
            SqlCommand cmd = null;
            Boolean insertado = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarVenta", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@medPago", venta.medPago);
                cmd.Parameters.AddWithValue("@numDoc", venta.numDoc);
                cmd.Parameters.AddWithValue("@nombreCli", venta.nombreCli);
                cmd.Parameters.AddWithValue("@cantidad", venta.cantidad);
                cmd.Parameters.AddWithValue("@montoTotal", venta.montoTotal);
                cmd.Parameters.AddWithValue("@fecharegistro", venta.fecharegistro);
                SqlParameter idOrdVen = new SqlParameter("@OrdenVentaID", SqlDbType.Int);
                idOrdVen.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(idOrdVen);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    insertado = true;
                    i = 0;
                    int.TryParse(cmd.Parameters["@OrdenVentaID"].Value.ToString(), out i);
                    venta.OrdenVentaID = i;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return insertado;
        }
    }
}

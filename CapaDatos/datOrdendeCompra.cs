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
    public class datOrdendeCompra
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly datOrdendeCompra _instancia = new datOrdendeCompra();
        //privado para evitar la instanciación directa
        public static datOrdendeCompra Instancia
        {
            get
            {
                return datOrdendeCompra._instancia;
            }
        }
        #endregion singleton
        #region metodos


        ////////////////////listado de Orden de Compra
        public List<entOrdendeCompra> ListarOrdenDeCompra()
        {
            SqlCommand cmd = null;
            List<entOrdendeCompra> lista = new List<entOrdendeCompra>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListarOrdenCompra", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entOrdendeCompra orden = new entOrdendeCompra();
                    orden.OrdencompraID = Convert.ToInt32(dr["OrdencompraID"]);
                    orden.PagoordencompraID = Convert.ToInt32(dr["PagoordencompraID"]);
                    orden.ProveedorID = Convert.ToInt32(dr["ProveedorID"]);
                    orden.Fecha = Convert.ToDateTime(dr["fecha"]);
                    orden.Total = Convert.ToDecimal(dr["total"]);
                    orden.Estado = Convert.ToBoolean(dr["estado"]);
                    lista.Add(orden);
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
            return lista;
        }

        public Boolean InsertarOrdenCompra(entOrdendeCompra orden)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarOrdenCompra", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@OrdencompraID", orden.OrdencompraID);
                cmd.Parameters.AddWithValue("@PagoordencompraID", orden.PagoordencompraID);
                cmd.Parameters.AddWithValue("@ProveedorID", orden.ProveedorID);
                cmd.Parameters.AddWithValue("@total", orden.Total);
                cmd.Parameters.AddWithValue("@fecha", orden.Fecha);
                cmd.Parameters.AddWithValue("@estado", orden.Estado);

                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    inserta = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return inserta;
        }

        public Boolean DeshabilitarOrdenCompra(entOrdendeCompra orden)
        {
            SqlCommand cmd = null;
            Boolean deshabilitar = false;
            try
            {
                SqlConnection con = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDeshabilitarOrdenCompra", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@OrdencompraID", orden.OrdencompraID);
                //cmd.Parameters.AddWithValue("@estado", orden.Estado);
                con.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    deshabilitar = true;
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
            return deshabilitar;
        }
        #endregion metodos
    }
}

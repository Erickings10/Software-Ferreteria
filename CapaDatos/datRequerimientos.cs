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
    public class datRequerimientos
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly datRequerimientos _instancia = new datRequerimientos();
        //privado para evitar la instanciación directa
        public static datRequerimientos Instancia
        {
            get
            {
                return datRequerimientos._instancia;
            }
        }
        #endregion singleton

        #region metodos
        ////////////////////listado de Requerimiento
        public List<entRequerimiento> ListarRequerimiento()
        {
            SqlCommand cmd = null;
            List<entRequerimiento> lista = new List<entRequerimiento>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListarRequerimiento", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    entRequerimiento Req = new entRequerimiento();

                    Req.RequerimientoID = Convert.ToInt32(dr["RequerimientoID"]);
                    Req.fecha = Convert.ToDateTime(dr["fecha"]);
                    Req.estado = Convert.ToBoolean(dr["estado"]);
                    lista.Add(Req);

                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return lista;
        }

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


        public Boolean InsertarRequerimiento(entRequerimiento Req)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarRequerimiento", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                //cmd.Parameters.AddWithValue("@RequerimientoID", Req.RequerimientoID);
                cmd.Parameters.AddWithValue("@fecha", Req.fecha);   
                cmd.Parameters.AddWithValue("@estado", Req.estado);

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


        /*public Boolean DeshabilitarRequerimiento(entRequerimiento Req)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDeshabilitarRequerimiento", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", Req.id);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    delete = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return delete;
        }*/

        


        #endregion metodos
    }

}

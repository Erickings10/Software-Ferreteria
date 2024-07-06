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
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListarRequerimiento", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entRequerimiento Req = new entRequerimiento();

                    Req.RequerimientoID = Convert.ToInt32(dr["RequerimientoID"]);;
                    Req.fecha = Convert.ToDateTime(dr["fecha"]);
                    Req.estado = Convert.ToBoolean(dr["estado"]);
                    lista.Add(Req);
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

        /*public Boolean InsertarRequerimiento(entRequerimiento Req)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertaRequerimiento", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@producto", Req.producto);
                cmd.Parameters.AddWithValue("@marca", Req.marca);
                cmd.Parameters.AddWithValue("@categoria", Req.categoria);
                cmd.Parameters.AddWithValue("@cantidad", Req.cantidad);
                cmd.Parameters.AddWithValue("@fecha", Req.fecha);
                cmd.Parameters.AddWithValue("@prioridad", Req.prioridad);
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
        public Boolean DeshabilitarRequerimiento(entRequerimiento Req)
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
        }

        */

        #endregion metodos

    }
}

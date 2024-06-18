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
                cmd = new SqlCommand("spListaRequerimientos", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entRequerimiento Req = new entRequerimiento();
                    Req.idRequer = Convert.ToInt32(dr["idRequer"]);
                    Req.prodRequer = Convert.ToString(dr["prodRequer"]);
                    Req.fechaRequer = Convert.ToDateTime(dr["fechaRequer"]);
                    Req.cantRequer = Convert.ToInt64(dr["cantRequer"]);
                    Req.marcaRequer = Convert.ToString(dr["marcaRequer"]);
                    Req.modelRequer = Convert.ToString(dr["modelRequer"]);
                    Req.estadRequer = Convert.ToBoolean(dr["estadRequer"]);
                    Req.priorRequer = Convert.ToString(dr["priorRequer"]);
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

        public Boolean InsertarRequerimiento(entRequerimiento Req)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertaRequerimiento", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@prodRequer", Req.prodRequer);
                cmd.Parameters.AddWithValue("@fechaRequer", Req.fechaRequer);
                cmd.Parameters.AddWithValue("@cantRequer", Req.cantRequer);
                cmd.Parameters.AddWithValue("@marcaRequer", Req.marcaRequer);
                cmd.Parameters.AddWithValue("@modelRequer", Req.modelRequer);
                cmd.Parameters.AddWithValue("@estadRequer", Req.estadRequer);
                cmd.Parameters.AddWithValue("@priorRequer", Req.priorRequer);
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
                cmd.Parameters.AddWithValue("@idRequer", Req.idRequer);
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



        #endregion metodos

    }
}

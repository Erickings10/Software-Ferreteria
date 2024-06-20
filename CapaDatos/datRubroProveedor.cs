using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting;

namespace CapaDatos
{
    public class datRubroProveedor
    {
        #region sigleton

        private static readonly datRubroProveedor _instancia = new datRubroProveedor();
        public static datRubroProveedor Instancia
        {
            get 
            { 
            return datRubroProveedor._instancia;
            }
        }

        #endregion sigleton

        #region metodos

        public List<entRubroProveedor> ListarRubro()
        {
            SqlCommand cmd = null;
            List<entRubroProveedor> lista = new List<entRubroProveedor> ();
            try
            {
                SqlConnection con = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListaRubro", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    entRubroProveedor rub = new entRubroProveedor();
                    rub.idRubro = Convert.ToInt32(rd["IDRubro"]);
                    rub.nameRubro = Convert.ToString(rd["Rubro"]);
                    rub.fecRegistro = Convert.ToDateTime(rd["FechaRub"]);
                    rub.estRubro = Convert.ToBoolean(rd["EstadoRub"]);
                    lista.Add(rub);
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
            return lista;
        }

        public Boolean InsertaRubro(entRubroProveedor Rub) 
        {
            SqlCommand cmd = null;
            Boolean insertar = false;
            try 
            {
                SqlConnection con = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarRubro",con);
                cmd.Parameters.AddWithValue("@NombreRub", Rub.nameRubro);
                cmd.Parameters.AddWithValue("@FechaRegistro", Rub.fecRegistro);
                cmd.Parameters.AddWithValue("@EstadoRub", Rub.estRubro);
                con.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0) 
                {
                    insertar = true;
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
            return insertar;
        }

        public Boolean EditaRubro(entRubroProveedor Rub) 
        {
            SqlCommand cmd = null;
            Boolean editar = false;
            try
            {
                SqlConnection con = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditarRubro", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IDrubro", Rub.idRubro);
                cmd.Parameters.AddWithValue("@NombreRub", Rub.nameRubro);
                cmd.Parameters.AddWithValue("@FechaRegistro", Rub.fecRegistro);
                cmd.Parameters.AddWithValue("@EstadoRub", Rub.estRubro);
                con.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    editar = true;
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
            return editar;
        }

        public Boolean DeshabilitarRubro(entRubroProveedor Rub)
        {
            SqlCommand cmd = null;
            Boolean deshabilitar = false;
            try
            {
                SqlConnection con = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDeshabilitarRubro", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IDrubro", Rub.idRubro);
                cmd.Parameters.AddWithValue("@EstadoRub", Rub.estRubro);
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

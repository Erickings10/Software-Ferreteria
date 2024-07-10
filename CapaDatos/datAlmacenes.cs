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
    public class datAlmacenes
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly datAlmacenes _instancia = new datAlmacenes();
        //privado para evitar la instanciación directa
        public static datAlmacenes Instancia
        {
            get
            {
                return datAlmacenes._instancia;
            }
        }
        #endregion singleton

        #region metodos
        ////////////////////listado de Almacenes
        public List<entAlmacenes> ListarAlmacenes()
        {
            SqlCommand cmd = null;
            List<entAlmacenes> lista = new List<entAlmacenes>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListarAlmacenes", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entAlmacenes Alm = new entAlmacenes();
                    Alm.AlmacenID = Convert.ToInt32(dr["AlmacenID"]);
                    Alm.descripcion = Convert.ToString(dr["descripcion"]);
                    Alm.cantidad = Convert.ToInt32(dr["cantidad"]);
                    Alm.estado = Convert.ToBoolean(dr["estado"]);
                    Alm.PrecioVenta = Convert.ToDecimal(dr["PrecioVenta"]);
                    Alm.desPro = Convert.ToString(dr["desPro"]);
                    lista.Add(Alm);
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
        public Boolean InsertarAlmacenes(entAlmacenes Alm)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarAlmacenes", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@descripcion", Alm.descripcion);
                cmd.Parameters.AddWithValue("@cantidad", Alm.cantidad);
                cmd.Parameters.AddWithValue("@estado", Alm.estado);

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

        public Boolean EditarAlmacenes(entAlmacenes Alm)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditarAlmacenes", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@AlmacenID", Alm.AlmacenID);
                cmd.Parameters.AddWithValue("@descripcion", Alm.descripcion);
                cmd.Parameters.AddWithValue("@cantidad", Alm.cantidad);
                cmd.Parameters.AddWithValue("@estado", Alm.estado);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    edita = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return edita;
        }

        public Boolean DeshabilitarAlmacen(entAlmacenes Alm)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDeshabilitarAlmacenes", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@AlmacenID", Alm.AlmacenID);
                //cmd.Parameters.AddWithValue("@estado", Alm.estado);
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

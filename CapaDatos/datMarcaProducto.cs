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
    public class datMarcaProducto
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly datMarcaProducto _instancia = new datMarcaProducto();
        //privado para evitar la instanciación directa
        public static datMarcaProducto Instancia
        {
            get
            {
                return datMarcaProducto._instancia;
            }
        }
        #endregion singleton

        #region metodos
        ////////////////////listado de Proveedores
        public List<entMarcaProducto> ListarMarcaProducto()
        {
            SqlCommand cmd = null;
            List<entMarcaProducto> lista = new List<entMarcaProducto>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListarMarca", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entMarcaProducto Mar = new entMarcaProducto();
                    Mar.MarcaproductoID = Convert.ToInt32(dr["MarcaproductoID"]);
                    Mar.marca = Convert.ToString(dr["marca"]);
                    Mar.estado = Convert.ToBoolean(dr["estado"]);
                    lista.Add(Mar);
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

        public Boolean InsertarMarca(entMarcaProducto Mar)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarMarca", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@marca", Mar.marca);
                cmd.Parameters.AddWithValue("@estado", Mar.estado);
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

        public Boolean EditarMarca(entMarcaProducto Mar)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditarMarca", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MarcaproductoID", Mar.MarcaproductoID);
                cmd.Parameters.AddWithValue("@marca", Mar.marca);
                cmd.Parameters.AddWithValue("@estado", Mar.estado);
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

        public Boolean DeshabilitarMarca(entMarcaProducto Mar)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDeshabilitarMarca", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MarcaproductoID", Mar.MarcaproductoID);
                //cmd.Parameters.AddWithValue("@estado", Mar.estado);
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

        public List<entMarcaProducto> ListarReporteMarcaProducto()
        {
            SqlCommand cmd = null;
            List<entMarcaProducto> lista = new List<entMarcaProducto>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListarReporteMarca", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entMarcaProducto Mar = new entMarcaProducto();
                    Mar.MarcaproductoID = Convert.ToInt32(dr["MarcaproductoID"]);
                    Mar.marca = Convert.ToString(dr["marca"]);
                    Mar.estado = Convert.ToBoolean(dr["estado"]);
                    lista.Add(Mar);
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


        #endregion metodos
    }
}

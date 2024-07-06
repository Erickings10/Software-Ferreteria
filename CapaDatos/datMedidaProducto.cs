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
    public class datMedidaProducto
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly datMedidaProducto _instancia = new datMedidaProducto();
        //privado para evitar la instanciación directa
        public static datMedidaProducto Instancia
        {
            get
            {
                return datMedidaProducto._instancia;
            }
        }
        #endregion singleton

        #region metodos
        ////////////////////listado de medida de productos
        public List<entMedidaProducto> ListarMedidaProducto()
        {
            SqlCommand cmd = null;
            List<entMedidaProducto> lista = new List<entMedidaProducto>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListarMedida", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entMedidaProducto Med = new entMedidaProducto();
                    Med.MedidaproductoID = Convert.ToInt32(dr["MedidaproductoID"]);
                    Med.descripcion = Convert.ToString(dr["descripcion"]);
                    Med.prefijo = Convert.ToString(dr["prefijo"]);
                    Med.estado = Convert.ToBoolean(dr["estado"]);
                    lista.Add(Med);
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
        public List<entMedidaProducto> ListarReporteMedidaProducto()
        {
            SqlCommand cmd = null;
            List<entMedidaProducto> lista = new List<entMedidaProducto>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListarReporteMedida", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entMedidaProducto Mar = new entMedidaProducto();
                    Mar.MedidaproductoID = Convert.ToInt32(dr["MedidaproductoID"]);
                    Mar.descripcion = Convert.ToString(dr["descripcion"]);
                    Mar.prefijo = Convert.ToString(dr["prefijo"]);
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

        public Boolean InsertarMedida(entMedidaProducto Med)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarMedida", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@descripcion", Med.descripcion);
                cmd.Parameters.AddWithValue("@prefijo", Med.prefijo);
                cmd.Parameters.AddWithValue("@estado", Med.estado);
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

        public Boolean EditarMedida(entMedidaProducto Med)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditarMedida", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MedidaproductoID", Med.MedidaproductoID);
                cmd.Parameters.AddWithValue("@descripcion", Med.descripcion);
                cmd.Parameters.AddWithValue("@prefijo", Med.prefijo);
                cmd.Parameters.AddWithValue("@estado", Med.estado);
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

        public Boolean DeshabilitarMedida(entMedidaProducto Med)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDeshabilitarMedida", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MedidaproductoID", Med.MedidaproductoID);
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

        

        #endregion metodos
    }
}

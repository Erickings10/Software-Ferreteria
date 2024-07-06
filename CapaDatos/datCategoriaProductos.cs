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
    public class datCategoriaProductos
    {
        #region singleton

        private static readonly datCategoriaProductos _instancia = new datCategoriaProductos();
        public static datCategoriaProductos Instancia
        {
            get
            {
                return datCategoriaProductos._instancia;
            }
        }

        #endregion singleton

        #region metodos

        public List<entCategoriaProductos> ListarCategoriaProducto()
        {
            List<entCategoriaProductos> lista = new List<entCategoriaProductos>();
            try
            {
                using (SqlConnection con = Conexion.Instancia.Conectar())
                {
                    using (SqlCommand cmd = new SqlCommand("spListarCategoria", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        con.Open();
                        using (SqlDataReader cprod = cmd.ExecuteReader())
                        {
                            while (cprod.Read())
                            {
                                entCategoriaProductos cp = new entCategoriaProductos();
                                cp.CategoriaproductoID = Convert.ToInt32(cprod["CategoriaproductoID"]);
                                cp.descripcion = Convert.ToString(cprod["descripcion"]);
                                cp.estado = Convert.ToBoolean(cprod["estado"]);
                                lista.Add(cp);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Aquí puedes loggear el error o manejarlo de manera más específica
                throw new Exception("Error al listar las categorías de productos", ex);
            }
            return lista;
        }

        public Boolean InsertaCategoriaProducto(entCategoriaProductos cp)
        {
            Boolean insertar = false;
            try
            {
                using (SqlConnection con = Conexion.Instancia.Conectar())
                {
                    using (SqlCommand cmd = new SqlCommand("spInsertarCategoria", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@descripcion", cp.descripcion);
                        cmd.Parameters.AddWithValue("@estado", cp.estado);
                        con.Open();
                        int i = cmd.ExecuteNonQuery();
                        if (i > 0)
                        {
                            insertar = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Aquí puedes loggear el error o manejarlo de manera más específica
                throw new Exception("Error al insertar la categoría de producto", ex);
            }
            return insertar;
        }


        public Boolean EditaCategoriaProducto(entCategoriaProductos cp)
        {
            SqlCommand cmd = null;
            Boolean editar = false;
            try
            {
                SqlConnection con = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditarCategoria", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CategoriaproductoID", cp.CategoriaproductoID);
                cmd.Parameters.AddWithValue("@descripcion", cp.descripcion);
                cmd.Parameters.AddWithValue("@estado", cp.estado);
                con.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    editar = true;
                }
            }
            catch (Exception ex)
            {
                // Aquí puedes loggear el error o manejarlo de manera más específica
                throw new Exception("Error al editar la categoría de producto", ex);
            }
            finally
            {
                if (cmd != null && cmd.Connection != null)
                {
                    cmd.Connection.Close();
                }
            }
            return editar;
        }


        public Boolean DeshabilitarCategoriaProducto(entCategoriaProductos cp)
        {
            SqlCommand cmd = null;
            Boolean deshabilitar = false;
            try
            {
                SqlConnection con = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDeshabilitarCategoria", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CategoriaproductoID", cp.CategoriaproductoID);
                //cmd.Parameters.AddWithValue("@estado", cp.estado);
                con.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    deshabilitar = true;
                }
            }
            catch (Exception ex)
            {
                // Aquí puedes loggear el error o manejarlo de manera más específica
                throw new Exception("Error al deshabilitar la Categoria", ex);
            }
            finally
            {
                if (cmd != null && cmd.Connection != null)
                {
                    cmd.Connection.Close();
                }
            }
            return deshabilitar;
        }

        public List<entCategoriaProductos> ListarReporteCategoriaProducto()
        {
            SqlCommand cmd = null;
            List<entCategoriaProductos> lista = new List<entCategoriaProductos>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListarReporteCategoria", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entCategoriaProductos Cat = new entCategoriaProductos();
                    Cat.CategoriaproductoID = Convert.ToInt32(dr["CategoriaproductoID"]);
                    Cat.descripcion = Convert.ToString(dr["descripcion"]);
                    Cat.estado = Convert.ToBoolean(dr["estado"]);
                    lista.Add(Cat);
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




            #endregion metodos




        }
    } 
}
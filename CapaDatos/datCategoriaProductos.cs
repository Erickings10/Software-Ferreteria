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
                    using (SqlCommand cmd = new SqlCommand("spListaCategoriaProducto", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        con.Open();
                        using (SqlDataReader cprod = cmd.ExecuteReader())
                        {
                            while (cprod.Read())
                            {
                                entCategoriaProductos cp = new entCategoriaProductos();
                                cp.IdCategoriaProducto = Convert.ToInt32(cprod["IdCategoriaProducto"]);
                                cp.nombreCategoriaProducto = Convert.ToString(cprod["nombreCategoriaProducto"]);
                                cp.FechaRegistro = Convert.ToDateTime(cprod["FechaRegistro"]);
                                cp.EstadoCategoriaProducto = Convert.ToBoolean(cprod["EstadoCategoriaProducto"]);
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
                    using (SqlCommand cmd = new SqlCommand("spInsertaCategoriaProducto", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@nombreCategoriaProducto", cp.nombreCategoriaProducto);
                        cmd.Parameters.AddWithValue("@FechaRegistro", cp.FechaRegistro);
                        cmd.Parameters.AddWithValue("@EstadoCategoriaProducto", cp.EstadoCategoriaProducto);
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
                cmd = new SqlCommand("spEditaCategoriaProducto", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdCategoriaProducto", cp.IdCategoriaProducto);
                cmd.Parameters.AddWithValue("@nombreCategoriaProducto", cp.nombreCategoriaProducto);
                cmd.Parameters.AddWithValue("@FechaRegistro", cp.FechaRegistro);
                cmd.Parameters.AddWithValue("@EstadoCategoriaProducto", cp.EstadoCategoriaProducto);
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
                cmd = new SqlCommand("spDeshabilitaCategoriaProducto", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdCategoriaProducto", cp.IdCategoriaProducto);
                //cmd.Parameters.AddWithValue("@EstadoCategoriaProducto", cp.EstadoCategoriaProducto);
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






















        #endregion metodos











    }
}

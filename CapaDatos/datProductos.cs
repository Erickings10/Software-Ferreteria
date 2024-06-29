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
    public class datProductos
    {


        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly datProductos _instancia = new datProductos();
        //privado para evitar la instanciación directa
        public static datProductos Instancia
        {
            get
            {
                return datProductos._instancia;
            }
        }
        #endregion singleton


        #region metodos

        public (int MarcaProductoID, int CategoriaProductoID) ObtenerProductoPorID(int productoID)
        {
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); // singleton
                cmd = new SqlCommand("spObtenerProductoPorID", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@ProductoID", productoID));
                cn.Open();
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    int marcaProductoID = Convert.ToInt32(dr["MarcaProductoID"]);
                    int categoriaProductoID = Convert.ToInt32(dr["CategoriaProductoID"]);
                    return (marcaProductoID, categoriaProductoID);
                }
                throw new Exception("Producto no encontrado.");
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (dr != null && !dr.IsClosed)
                {
                    dr.Close();
                }
                if (cmd != null)
                {
                    cmd.Connection.Close();
                }
            }
        }

            ////////////////////listado de Productos
        public List<entDescProducto> ListarProductos()
        {
            SqlCommand cmd = null;
            List<entDescProducto> lista = new List<entDescProducto>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListarProductos", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entDescProducto Prod = new entDescProducto();
                    Prod.ProductoID = Convert.ToInt32(dr["ProductoID"]);
                    Prod.categoria = Convert.ToString(dr["categoria"]);
                    Prod.marca = Convert.ToString(dr["marca"]);
                    Prod.descripcion = Convert.ToString(dr["descripcion"]);
                    Prod.cantidad = Convert.ToInt64(dr["cantidad"]);
                    Prod.estado = Convert.ToBoolean(dr["estado"]);
                    lista.Add(Prod);
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
        public List<entDescProducto> ListarReporteProducto()
        {
            SqlCommand cmd = null;
            List<entDescProducto> lista = new List<entDescProducto>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListarReporteProductos", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entDescProducto pro = new entDescProducto();
                    pro.ProductoID = Convert.ToInt32(dr["ProductoID"]);
                    pro.categoria = Convert.ToString(dr["categoria"]);
                    pro.marca = Convert.ToString(dr["marca"]);
                    pro.descripcion = Convert.ToString(dr["descripcion"]);
                    pro.cantidad = Convert.ToInt64(dr["cantidad"]);
                    pro.estado = Convert.ToBoolean(dr["estado"]);
                    lista.Add(pro);
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


        public Boolean InsertarProductos(entProductos Prod)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarProductos", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CategoriaproductoID", Prod.CategoriaproductoID);
                cmd.Parameters.AddWithValue("@MarcaproductoID", Prod.MarcaproductoID);
                cmd.Parameters.AddWithValue("@descripcion", Prod.descripcion);
                cmd.Parameters.AddWithValue("@cantidad", Prod.cantidad);
                cmd.Parameters.AddWithValue("@estado", Prod.estado);

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


        public Boolean EditarProducto(entProductos Pro)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditarProducto", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ProductoID", Pro.ProductoID);
                cmd.Parameters.AddWithValue("@CategoriaproductoID", Pro.CategoriaproductoID);
                cmd.Parameters.AddWithValue("@descripcion", Pro.descripcion);
                cmd.Parameters.AddWithValue("@cantidad", Pro.cantidad);
                cmd.Parameters.AddWithValue("@estado", Pro.estado);
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


        #endregion metodos









    }
}

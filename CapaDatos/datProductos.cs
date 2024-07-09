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
                    Prod.categoria = Convert.ToString(dr["desCategoria"]);
                    Prod.marca = Convert.ToString(dr["desMarca"]);
                    Prod.medida = Convert.ToString(dr["prefijo"]);
                    Prod.descripcion = Convert.ToString(dr["descripcion"]);
                    Prod.precioCompra = Convert.ToDecimal(dr["precioCompra"]);
                    Prod.precioVenta = Convert.ToDecimal(dr["precioVenta"]);
                    Prod.fecha = Convert.ToDateTime(dr["fecha"]);
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
                    pro.medida = Convert.ToString(dr["medida"]);
                    pro.descripcion = Convert.ToString(dr["descripcion"]);
                    pro.precioCompra = Convert.ToDecimal(dr["precioCompra"]);
                    pro.precioVenta = Convert.ToDecimal(dr["precioVenta"]);
                    pro.fecha = Convert.ToDateTime(dr["fecha"]);
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
                cmd.Parameters.AddWithValue("@MedidaproductoID", Prod.MedidaproductoID);
                cmd.Parameters.AddWithValue("@descripcion", Prod.descripcion);
                cmd.Parameters.AddWithValue("@precioCompra", Prod.precioCompra);
                cmd.Parameters.AddWithValue("@precioVenta", Prod.precioVenta);
                cmd.Parameters.AddWithValue("@fecha", Prod.fecha);
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
        public entProductos BuscarProductoId(int idProducto)
        {
            SqlCommand cmd = null;
            entProductos Prod = new entProductos();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spBuscarProductoPorID", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ProductoID", idProducto);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Prod.ProductoID = Convert.ToInt16(dr["ProductoID"]);
                    Prod.descripcion = Convert.ToString(dr["descripcion"]);
                    //Prod.CategoriaproductoID = Convert.ToInt16(dr["CategoriaproductoID"]);
                    //Prod.MarcaproductoID = Convert.ToInt16(dr["MarcaproductoID"]);
                    //Prod.MedidaproductoID = Convert.ToInt16(dr["MedidaproductoID"]);
                    Prod.precioCompra = Convert.ToDecimal(dr["precioCompra"]);
                    Prod.precioVenta = Convert.ToDecimal(dr["precioVenta"]);
                    Prod.fecha = Convert.ToDateTime(dr["fecha"]);
                    Prod.estado = Convert.ToBoolean(dr["estado"]);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return Prod;

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
                cmd.Parameters.AddWithValue("@MarcaproductoID", Pro.MarcaproductoID);
                cmd.Parameters.AddWithValue("@MedidaproductoID", Pro.MedidaproductoID);
                cmd.Parameters.AddWithValue("@descripcion", Pro.descripcion);
                cmd.Parameters.AddWithValue("@precioCompra", Pro.precioCompra);
                cmd.Parameters.AddWithValue("@precioVenta", Pro.precioVenta);
                cmd.Parameters.AddWithValue("@fecha", Pro.fecha);
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


        public Boolean DeshabilitarProductos(entProductos Pro)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDeshabilitarProducto", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ProductoID", Pro.ProductoID);
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

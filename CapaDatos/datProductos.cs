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
        public List<entProductos> ListarProductos()
        {
            SqlCommand cmd = null;
            List<entProductos> lista = new List<entProductos>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListaProductos", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entProductos Prod = new entProductos();
                    Prod.Id_Producto= Convert.ToInt32(dr["Id_Producto"]);
                    Prod.Nombre_Producto = Convert.ToString(dr["Nombre_Producto"]);
                    Prod.Marca_Producto = Convert.ToString(dr["Marca_Producto"]);
                    Prod.Categoria_Producto = Convert.ToString(dr["Categoria_Producto"]);
                    Prod.Stock = Convert.ToInt32(dr["Stock"]);
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
        public Boolean InsertarProductos(entProductos Prod)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertaProductos",cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Nombre_Producto",Prod.Nombre_Producto);
                cmd.Parameters.AddWithValue("@Marca_Producto", Prod.Marca_Producto);
                cmd.Parameters.AddWithValue("@Categoria_Producto",Prod.Categoria_Producto);
                cmd.Parameters.AddWithValue("@Stock", Prod.Stock);

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




        #endregion metodos









    }
}

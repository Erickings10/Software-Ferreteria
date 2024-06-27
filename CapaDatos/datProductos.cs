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
                cmd = new SqlCommand("spListarProductos", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entProductos Prod = new entProductos();
                    Prod.ProductoID = Convert.ToInt32(dr["ProductoID"]);
                    Prod.CategoriaproductoID = Convert.ToInt32(dr["CategoriaproductoID"]);
                    Prod.MarcaproductoID = Convert.ToInt32(dr["MarcaproductoID"]);
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



        #endregion metodos









    }
}

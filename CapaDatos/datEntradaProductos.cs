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
    public class datEntradaProductos
    {

        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly datEntradaProductos _instancia = new datEntradaProductos();
        //privado para evitar la instanciación directa
        public static datEntradaProductos Instancia
        {
            get
            {
                return datEntradaProductos._instancia;
            }
        }
        #endregion singleton

        #region metodos
        ////////////////////listado de Entrada Productos
        public List<entEntradaProductos> ListarEntradaProductos()
        {
            SqlCommand cmd = null;
            List<entEntradaProductos> lista = new List<entEntradaProductos>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListarEntradaProducto", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entEntradaProductos ent = new entEntradaProductos();
                    ent.AlmacenID = Convert.ToInt32(dr["AlmacenID"]);
                    ent.ProductoID = Convert.ToInt32(dr["ProductoID"]);
                    ent.cantidad = Convert.ToInt64(dr["cantidad"]);
                    ent.descripcion = Convert.ToString(dr["descripcion"]);
                    ent.fecha = Convert.ToDateTime(dr["fecha"]);
                    ent.estado = Convert.ToBoolean(dr["estado"]);

                    SqlParameter idEntPro = new SqlParameter("@NotaentradaID", SqlDbType.Int);
                    idEntPro.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(idEntPro);

                    lista.Add(ent);
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

        public Boolean InsertarEntradaProducto(entEntradaProductos Ent)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarEntradaProducto", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@AlmacenID", Ent.AlmacenID);
                cmd.Parameters.AddWithValue("@ProductoID", Ent.ProductoID);
                cmd.Parameters.AddWithValue("@cantidad", Ent.cantidad);
                cmd.Parameters.AddWithValue("@descripcion", Ent.descripcion);
                cmd.Parameters.AddWithValue("@fecha", Ent.fecha);
                cmd.Parameters.AddWithValue("@estado", Ent.estado);

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

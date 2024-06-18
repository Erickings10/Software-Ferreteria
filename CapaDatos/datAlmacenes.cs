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
        ////////////////////listado de Proveedores
        public List<entAlmacenes> ListarAlmacenes()
        {
            SqlCommand cmd = null;
            List<entAlmacenes> lista = new List<entAlmacenes>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListaAlmacenes", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entAlmacenes Alm = new entAlmacenes();
                    Alm.id = Convert.ToInt32(dr["id"]);
                    Alm.descripcion = Convert.ToString(dr["descripcion"]);
                    Alm.cantidad = Convert.ToInt64(dr["cantidad"]);
                    Alm.tipo = Convert.ToString(dr["tipo"]);
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
                cmd = new SqlCommand("spInsertaAlmacenes", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@descripcion", Alm.descripcion);
                cmd.Parameters.AddWithValue("@cantidad", Alm.cantidad);
                cmd.Parameters.AddWithValue("@tipo", Alm.tipo);

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

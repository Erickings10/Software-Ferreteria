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
    public class datProveedor
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly datProveedor _instancia = new datProveedor();
        //privado para evitar la instanciación directa
        public static datProveedor Instancia
        {
            get
            {
                return datProveedor._instancia;
            }
        }
        #endregion singleton

        #region metodos
        ////////////////////listado de Proveedores
        public List<entProveedor> ListarProveedor()
        {
            SqlCommand cmd = null;
            List<entProveedor> lista = new List<entProveedor>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListaProveedor", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entProveedor Pro = new entProveedor();
                    Pro.idProveedor = Convert.ToInt32(dr["idProveedor"]);
                    Pro.rucProveedor = Convert.ToInt64(dr["rucProveedor"]);
                    Pro.ubiProv = Convert.ToInt32(dr["ubiProv"]);
                    Pro.sectorProve = Convert.ToString(dr["sectorProve"]);
                    Pro.correoProv = Convert.ToString(dr["correoProv"]);
                    Pro.telfProv = Convert.ToInt64(dr["telfProv"]);
                    Pro.estProv = Convert.ToBoolean(dr["estProv"]);
                    lista.Add(Pro);
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

        public Boolean InsertarProveedor(entProveedor Pro)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertaProveedor", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@rucProveedor", Pro.rucProveedor);
                cmd.Parameters.AddWithValue("@ubiProv", Pro.ubiProv);
                cmd.Parameters.AddWithValue("@sectorProve", Pro.sectorProve);
                cmd.Parameters.AddWithValue("@correoProv", Pro.correoProv);
                cmd.Parameters.AddWithValue("@telfProv", Pro.telfProv);
                cmd.Parameters.AddWithValue("@estProv", Pro.estProv);
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

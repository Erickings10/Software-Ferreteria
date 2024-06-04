using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CapaDatos
{
    public class datProveedor
    {
        #region sigleton
        private static readonly datProveedor _instancia = new datProveedor();
        public static datProveedor Instancia
        {
            get 
            { 
                return datProveedor._instancia;
            }
        }
        #endregion singleton

        #region metodos
        public List<entProveedor> ListaProveedor() 
        {
            SqlCommand cmd = null;
            List<entProveedor> listaPro = new List<entProveedor>();
            try 
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListaProveedor, cn");
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read()) 
                {
                    entProveedor pro = new entProveedor();
                    pro.IdProveedor = Convert.ToInt32(reader["IdProveedor"]);
                    pro.Documento = reader["Documento"].ToString();
                    pro.RazonSocial = reader["RazonSocial"].ToString();
                    pro.Correo = reader["Correo"].ToString();
                    pro.Telefono = reader["Telefono"].ToString();
                    listaPro.Add(pro);
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
            return listaPro;
        }
        #endregion metodos
    }

}

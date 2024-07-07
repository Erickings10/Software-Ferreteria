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
                cmd = new SqlCommand("spListarProveedor", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entProveedor Pro = new entProveedor();
                    Pro.idProveedor = Convert.ToInt32(dr["ProveedorID"]);
                    Pro.rucProveedor = Convert.ToInt64(dr["ruc"]);
                    Pro.ubiProv = Convert.ToInt32(dr["ubigeo"]);
                    Pro.sectorProve = Convert.ToInt32(dr["RubroproveedorID"]);
                    Pro.correoProv = Convert.ToString(dr["correo"]);
                    Pro.telfProv = Convert.ToInt64(dr["telefono"]);
                    Pro.fechaProv = Convert.ToDateTime(dr["fecha"]);
                    Pro.estProv = Convert.ToBoolean(dr["estado"]);
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
                cmd = new SqlCommand("spInsertarProveedor", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ruc", Pro.rucProveedor);
                cmd.Parameters.AddWithValue("@ubigeo", Pro.ubiProv);
                cmd.Parameters.AddWithValue("@RubroproveedorID", Pro.sectorProve);
                cmd.Parameters.AddWithValue("@correo", Pro.correoProv);
                cmd.Parameters.AddWithValue("@telefono", Pro.telfProv);
                cmd.Parameters.AddWithValue("@fecha", Pro.fechaProv);
                cmd.Parameters.AddWithValue("@estado", Pro.estProv);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    inserta = true;
                }
            }
            catch (SqlException ex)
            {
                if (ex.Number == 50000)
                {
                    throw new ApplicationException(ex.Message);
                }
                else
                {
                    throw ex;
                }
            }
            finally { cmd.Connection.Close(); }
            return inserta;
        }

        public Boolean EditaProveedor(entProveedor p)
        {
            SqlCommand cmd = null;
            Boolean editar = false;
            try
            {
                SqlConnection con = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spModificarProveedor", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ProveedorID", p.idProveedor);
                cmd.Parameters.AddWithValue("@ruc", p.rucProveedor);
                cmd.Parameters.AddWithValue("@ubigeo", p.ubiProv);
                cmd.Parameters.AddWithValue("@RubroproveedorID", p.sectorProve);
                cmd.Parameters.AddWithValue("@correo", p.correoProv);
                cmd.Parameters.AddWithValue("@telefono", p.telfProv);
                cmd.Parameters.AddWithValue("@fecha", p.fechaProv);
                cmd.Parameters.AddWithValue("@estado", p.estProv);
                con.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    editar = true;
                }
            }
            catch (SqlException ex)
            {
                if (ex.Number == 50000)
                {
                    throw new ApplicationException(ex.Message);
                }
                else
                {
                    throw ex;
                }
            }
            finally
            {
                cmd.Connection.Close();
            }
            return editar;
        }

        public Boolean DeshabilitarProveedor(entProveedor p)
        {
            SqlCommand cmd = null;
            Boolean deshabilitar = false;
            try
            {
                SqlConnection con = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDeshabilitarProveedor", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ProveedorID", p.idProveedor);
                cmd.Parameters.AddWithValue("@estado", p.estProv);
                con.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    deshabilitar = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return deshabilitar;
        }

        #endregion metodos

    }
}

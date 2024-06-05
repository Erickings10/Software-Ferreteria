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


            List<entProveedor> listaPro = new List<entProveedor>();

            try
            {
                using (SqlConnection cn = Conexion.Instancia.Conectar())
                {
                    using (SqlCommand cmd = new SqlCommand("spListaProveedor", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cn.Open();

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                entProveedor pro = new entProveedor
                                {
                                    IdProveedor = Convert.ToInt32(reader["IdProveedor"]),
                                    Documento = reader["Documento"].ToString(),
                                    RazonSocial = reader["RazonSocial"].ToString(),
                                    Correo = reader["Correo"].ToString(),
                                    Telefono = reader["Telefono"].ToString()
                                };
                                listaPro.Add(pro);
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                // Aquí puedes manejar la excepción o registrarla
                throw new Exception("Error al listar los proveedores", e);
            }

            return listaPro;


        }
        #endregion metodos

        /////////////////////////InsertaCliente
        public Boolean InsertarProveedor(entProveedor Cli)
        {
            Boolean inserta = false;

            try
            {
                using (SqlConnection cn = Conexion.Instancia.Conectar())
                {
                    using (SqlCommand cmd = new SqlCommand("spInsertaProveedor", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Documento", Cli.Documento);
                        cmd.Parameters.AddWithValue("@RazonSocial", Cli.RazonSocial);
                        cmd.Parameters.AddWithValue("@Correo", Cli.Correo);
                        cmd.Parameters.AddWithValue("@Telefono", Cli.Telefono);
                        cmd.Parameters.AddWithValue("@Estado", Cli.Estado);

                        cn.Open();
                        int i = cmd.ExecuteNonQuery();
                        if (i > 0)
                        {
                            inserta = true;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                
                throw new Exception("Error al insertar el cliente", e);
            }

            return inserta;
        }








    }

}

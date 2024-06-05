﻿using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logProveedor
    {

        #region sigleton
        private static readonly logProveedor _instancia = new logProveedor();
        public static logProveedor Instancia 
        {
            get 
            {
                return logProveedor._instancia;
            }
        }

        #endregion singleton

        #region metodos

        ///listado

        public List<entProveedor> ListaProveedores()
        {
            return datProveedor.Instancia.ListaProveedor();

        }

        ///inserta
        public void InsertaProveedor(entProveedor Cli)
        {
            datProveedor.Instancia.InsertarProveedor(Cli);
        }

        //edita
        public void EditaCliente(entProveedor Cli)
        {
            //datCliente.Instancia.EditarCliente(Cli);
        }
        public void DeshabilitarCliente(entProveedor Cli)
        {
            ///datCliente.Instancia.DeshabilitarCliente(Cli);
        }


        #endregion metodos







    }
}

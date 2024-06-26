﻿using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logAlmacenes
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logAlmacenes _instancia = new logAlmacenes();
        //privado para evitar la instanciación directa
        public static logAlmacenes Instancia
        {
            get
            {
                return logAlmacenes._instancia;
            }
        }

        #endregion singleton


        #region metodos

        public List<entAlmacenes> ListarAlmacenes()
        {
            return datAlmacenes.Instancia.ListarAlmacenes();

        }

        ///inserta
        public void InsertaAlmacenes(entAlmacenes Alm)
        {
            datAlmacenes.Instancia.InsertarAlmacenes(Alm);
        }

        public void EditarAlmacenes(entAlmacenes Alm)
        {
            datAlmacenes.Instancia.EditarAlmacenes(Alm);

        }

        public void DeshabilitarAlmacenes(entAlmacenes Alm)
        {
            datAlmacenes.Instancia.DeshabilitarAlmacen(Alm);
        }



        #endregion metodos








    }
}

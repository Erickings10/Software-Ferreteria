﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entProductos
    {

        public int ProductoID { get; set; }

        public int CategoriaproductoID { get; set; }

        public int MarcaproductoID { get; set; }

        public string descripcion { get; set; }

        public Int64 cantidad { get; set; }

        public Boolean estado { get; set; }



    }

    public class entDescProducto
    {
        public int ProductoID { get; set; }

        public string categoria { get; set; }

        public string marca { get; set; }

        public string descripcion { get; set; }

        public Int64 cantidad { get; set; }

        public Boolean estado { get; set; }
    }


}

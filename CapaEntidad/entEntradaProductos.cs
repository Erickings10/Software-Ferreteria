using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entEntradaProductos
    {

        public int DetalleentradaproductoID { get; set; }

        public int AlmacenID { get; set; }

        public int ProductoID { get; set; }

        public Int64 cantidad {  get; set; }

        public string descripcion { get; set; }

        public DateTime fecha { get; set; }

        public Boolean estado {  get; set; }


    }   
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeptunoDataBase
{
    public class Productos
    {

        public int idproducto { get; set; }
        public string nombreProducto { get; set; }
        public int idProveedor { get; set; }
        public int idCategoria { get; set; }
        public string cantidadPorUnidad { get; set; }


    }
}

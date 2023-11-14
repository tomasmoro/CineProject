using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataApi.Dominio
{
    internal class Producto
    {
        public int cod_producto { get; set; }
        public string descripcion { get; set; }
        public double precio { get; set; }
        public double peso { get; set; }
    }
}

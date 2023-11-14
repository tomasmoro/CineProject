using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataApi.Dominio
{
    internal class ProductoDetalle
    {
        public int cod_detalle { get; set; }
        public Producto producto { get; set; }
        public int cantidad { get; set; }
        public double total { get; set; }

    }
}

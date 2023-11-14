using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataApi.Dominio
{
    internal class Factura
    {
        public int nro_factura { get; set; }    
        public DateTime fecha { get; set; }
        public Vendedor vendedor { get; set; }
        public FormaPago formaPago { get; set; }
        public Cliente cliente { get; set; }
        public Funcion funcion { get; set; }

    }
}

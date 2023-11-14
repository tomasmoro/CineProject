using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataApi.Dominio
{
    internal class PromocionCodigo
    {
        public int id { get; set; }
        public double porcentaje { get; set; }
        public double descripcion { get; set; }
        public bool estaActivo { get; set; }
    }
}

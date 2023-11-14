using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataApi.Dominio
{
    internal class Sala
    {
        public int id { get; set; }
        public TipoSala tipo { get; set; }

        public List<Butaca> butacas { get; set; }
    }
}

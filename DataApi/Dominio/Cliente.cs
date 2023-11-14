using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataApi.Dominio
{
    internal class Cliente
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public DateTime nacimiento { get; set; }
        public string mail { get; set; }
        public string telefono { get; set; }
        public Barrio barrio { get; set; }
    }
}

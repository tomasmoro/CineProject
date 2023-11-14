using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataApi.Dominio
{
    internal class Funcion
    {
        public int id { get; set; }
        public Sala sala { get; set; }
        public Pelicula pelicula { get; set; }
        public Lenguaje lenguaje { get; set; }
        public DateTime fecha { get; set; }
        public float precio_gral { get; set; }

    }
}

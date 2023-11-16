using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataApi.Dominio
{
    public class Lenguaje
    {
        public int id_lenguaje { get; set; }
        public string lenguaje { get; set; }

        public Lenguaje(int id_lenguaje, string lenguaje)
        {
            this.id_lenguaje = id_lenguaje;
            this.lenguaje = lenguaje;
        }

    }
}

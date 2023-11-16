using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataApi.Dominio
{
    public class Lenguaje
    {
        private int id_lenguaje;
        private string lenguaje;

        public Lenguaje(int id_lenguaje, string lenguaje)
        {
            this.id_lenguaje = id_lenguaje;
            this.lenguaje = lenguaje;
        }

        public int id { get; set; }
        public string descripcion { get; set; }
    }
}

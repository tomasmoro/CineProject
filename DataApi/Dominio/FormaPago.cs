using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataApi.Dominio
{
    public class FormaPago
    {
        private string nombre;

        public FormaPago(int id, string nombre)
        {
            this.id = id;
            this.nombre = nombre;
        }

        public int id { get; set; }
        public string descripcion { get; set; }

        public override string ToString()
        {
            return nombre;
        }
    }
}

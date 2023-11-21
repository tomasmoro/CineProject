using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataApi.Dominio
{
    public class Vendedor
    {
        public int id_vendedor { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public DateTime fecha_nacimiento { get; set; }
        public string mail { get; set; }
        public string telefono { get; set; }
        public Barrio barrio { get; set; }
        public Vendedor(int id_vendedor, string nombre, string apellido) 
        {
            this.id_vendedor = id_vendedor;
            this.nombre = nombre;
            this.apellido = apellido;
        }

        public override string ToString()
        {
            return nombre + " " + apellido;
        }
    }
}

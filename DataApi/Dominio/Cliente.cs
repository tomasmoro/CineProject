using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataApi.Dominio
{
    public class Cliente
    {
        public Cliente(int id_cliente, string nombre, string apellido)
        {
            this.id_cliente = id_cliente;
            this.nombre = nombre;
            this.apellido = apellido;
        }
        
        public int id_cliente { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public DateTime fecha_nacimiento { get; set; }
        public string mail { get; set; }
        public string telefono { get; set; }
        public Barrio barrio { get; set; }


        public override string ToString()
        {
            return nombre +" "+ apellido;
        }
    }
}

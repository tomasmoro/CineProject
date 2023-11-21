using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataApi.Dominio
{
    public class ButacaSala
    {

        public ButacaSala(int id_butaca_sala, int asiento, int fila, Sala sala )
        {
            this.id_butaca_sala = id_butaca_sala;
            this.asiento = asiento;
            this.fila = fila;
            this.sala = sala;
        }

        public ButacaSala(int asiento, int fila)
        {
            this.asiento = asiento;
            this.fila = fila;
        }
        public ButacaSala()
        {
            
        }

        public int id_butaca_sala { get; set; }
        public int asiento { get; set; }
        public int fila { get; set; }
        public Sala sala { get; set; }
    }
}

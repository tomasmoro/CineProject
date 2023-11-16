using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataApi.Dominio
{
    public class Sala
    {
        private int nro_sala;
        private TipoSala tipoSala;

        public Sala(int nro_sala, TipoSala tipoSala)
        {
            this.nro_sala = nro_sala;
            this.tipoSala = tipoSala;
        }

        public int id { get; set; }
        public TipoSala tipo { get; set; }

        public List<Butaca> butacas { get; set; }
    }
}

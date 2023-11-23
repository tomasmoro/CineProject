using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataApi.Dominio
{
    public class Sala
    {
        public Sala(int nro_sala)
        {
            this.nro_sala = nro_sala;
        }

        public Sala(int nro_sala, TipoSala tipoSala)
        {
            this.nro_sala = nro_sala;
            this.tipoSala = tipoSala;
        }
        public Sala()
        {
            
        }

        public int nro_sala { get; set; }
        public TipoSala tipoSala { get; set; }

        public List<Butaca> butacas { get; set; }

        public string checkBoxTitle { get { return "Sala " + nro_sala; } }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataApi.Dominio
{
    public class TicketDetalle
    {

        public int cod_ticket { get; set; }
        public ButacaSala butaca { get; set; }
        public double total { get; set; }
        public TicketDetalle()
        {
            
        }

        public TicketDetalle(ButacaSala butaca,  double total)
        {
            this.butaca = butaca;
            this.total = total;
        }
    }
}

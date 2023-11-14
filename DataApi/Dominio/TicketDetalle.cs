﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataApi.Dominio
{
    internal class TicketDetalle
    {

        public int cod_ticket { get; set; }
        public Butaca butaca { get; set; }
        public PromocionCodigo id_promocion_codigo { get; set; }
        public PromocionEdad id_promocion_edad { get; set; }
        public double total { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataApi.Dominio
{
    public class FormaPago
    {

        public FormaPago(int id_forma_pago, string forma_pago)
        {
            this.id_forma_pago = id_forma_pago;
            this.forma_pago = forma_pago;
        }

        public int id_forma_pago { get; set; }
        public string forma_pago { get; set; }

        public override string ToString()
        {
            return forma_pago;
        }
    }
}

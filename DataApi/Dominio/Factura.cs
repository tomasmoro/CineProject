using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataApi.Dominio
{
    public class Factura
    {
        public int nro_factura { get; set; }    
        public DateTime fecha { get; set; }
        public Vendedor vendedor { get; set; }
        public FormaPago formaPago { get; set; }
        public Cliente cliente { get; set; }
        public Funcion funcion { get; set; }
        
        public List<TicketDetalle> tickets { get; set; }

        public Factura(DateTime fecha, Vendedor vendedor, FormaPago formaPago, Cliente cliente, Funcion funcion, List<TicketDetalle> tickets)
        {
            this.fecha = fecha;
            this.vendedor = vendedor;
            this.formaPago = formaPago;
            this.cliente = cliente;
            this.funcion = funcion;
            this.tickets = tickets;
        }

        public Factura(Funcion funcion, List<TicketDetalle> tickets)
        {
            this.funcion = funcion;
            this.tickets = tickets;
        }

        public Factura()
        {
            
        }
    }
}

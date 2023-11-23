using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataApi.Dominio
{
    public class QrSendModel
    {
        public QrSendModel(int nro_factura, string titulo, int nro_sala, int id_butaca_sala, string asiento)
        {
            this.Nro_factura = nro_factura;
            this.Titulo = titulo;
            this.Nro_sala = nro_sala;
            this.id_butaca_sala = id_butaca_sala;
            this.asiento = asiento;
        }

        public int Nro_factura { get; set; }
        public string Titulo { get; set; }
        public int Nro_sala { get; set; }
        public int id_butaca_sala { get; set; }
        public string asiento { get; set; }
    }
}

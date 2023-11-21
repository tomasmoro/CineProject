namespace DataApi.Dominio
{
    public class Butaca
    {

        public Butaca(int id_butaca_sala, int asiento, int fila, bool esta_disponible)
        {
            this.id_butaca_sala = id_butaca_sala;
            this.asiento = asiento;
            this.fila = fila;
            this.esta_disponible = esta_disponible;
        }
        
        public Butaca(int asiento, int fila)
        {
            this.asiento = asiento;
            this.fila = fila;
        }

        public Butaca()
        {
            
        }
        public int id_butaca_sala { get; set; } 
        public int asiento { get; set; } 
        public int fila { get; set; }
        public bool esta_disponible { get; set; }

    }
}
namespace DataApi.Dominio
{
    public class Butaca
    {
        public bool estaDisponible { get; set; }

        public Butaca(int id, int asiento, int fila, bool estaDisponible)
        {
            this.id = id;
            this.asiento = asiento;
            this.fila = fila;
            this.estaDisponible = estaDisponible;
        }
        
        public Butaca(int asiento, int fila)
        {
            this.asiento = asiento;
            this.fila = fila;
        }

        public int id { get; set; } 
        public int asiento { get; set; } 
        public int fila { get; set; } 

    }
}
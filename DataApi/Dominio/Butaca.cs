namespace DataApi.Dominio
{
    public class Butaca
    {
        private bool estaDisponible;

        public Butaca(int id, int asiento, int fila, bool estaDisponible)
        {
            this.id = id;
            this.asiento = asiento;
            this.fila = fila;
            this.estaDisponible = estaDisponible;
        }

        public int id { get; set; } 
        public int asiento { get; set; } 
        public int fila { get; set; } 

    }
}
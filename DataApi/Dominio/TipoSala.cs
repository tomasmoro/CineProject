namespace DataApi.Dominio
{
    public class TipoSala
    {
        private int id_tipo_sala;
        private string tipo_sala;

        public TipoSala(int id_tipo_sala, string tipo_sala)
        {
            this.id_tipo_sala = id_tipo_sala;
            this.tipo_sala = tipo_sala;
        }

        public int id { get; set; }
        public string descripcion { get; set; }
    }
}
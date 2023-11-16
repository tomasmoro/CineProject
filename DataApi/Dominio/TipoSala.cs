namespace DataApi.Dominio
{
    public class TipoSala
    {
        public int Id_tipo_sala { get; set; }
        public string Tipo_sala { get; set; }

        public TipoSala(int id_tipo_sala, string tipo_sala)
        {
            this.Id_tipo_sala = id_tipo_sala;
            this.Tipo_sala = tipo_sala;
        }
        public TipoSala()
        {
            
        }
    }
}
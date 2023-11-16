using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataApi.Dominio
{
    public class Pelicula
    {
        public int id_pelicula { get; set; }
        public string titulo { get; set; }
        public DateTime fecha_estreno { get; set; }
        public int duracion { get; set; }
        public List<Genero> generos{ get; set; }
        public List<Actor> actores { get; set; }
        public List<Director> categorias { get; set; }
        public List<Categoria> directores { get; set; }

        public Pelicula(int id_pelicula, string titulo, DateTime fecha_estreno, int duracion)
        {
            this.id_pelicula = id_pelicula;
            this.titulo = titulo;
            this.fecha_estreno = fecha_estreno;
            this.duracion = duracion;
        }
        public Pelicula(int id_pelicula, string titulo)
        {
            this.id_pelicula = id_pelicula;
            this.titulo = titulo;
        }

        public Pelicula()
        {
        }
    }
}

﻿using System;
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



    }
}

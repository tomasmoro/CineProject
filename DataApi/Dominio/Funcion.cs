﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataApi.Dominio
{
    public class Funcion
    {
        public int id { get; set; }
        public Sala sala { get; set; }
        public Pelicula pelicula { get; set; }
        public Lenguaje lenguaje { get; set; }
        public DateTime fecha { get; set; }
        public float precio_gral { get; set; }

        public Funcion(int id, Sala sala, Pelicula pelicula, Lenguaje lenguaje, DateTime fecha, float precio_gral)
        {
            this.id = id;
            this.sala = sala;
            this.pelicula = pelicula;
            this.lenguaje = lenguaje;
            this.fecha = fecha;
            this.precio_gral = precio_gral;
        }
    }

}

using DataApi.Dominio;
using DataAPI.Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataApi.DAO.Funciones
{
    public class FuncionDAO : IFuncionDAO
    {
        public List<Butaca> ObtenerButacasDisponibles(Funcion funcion)
        {
            List<Butaca> butacas = new List<Butaca>();
            List<Parametro> parametros = new List<Parametro>();

            parametros.Add(new Parametro("@id_funcion", funcion.id));
            parametros.Add(new Parametro("@id_sala", funcion.sala));
                
            DataTable tabla = HelperDAO.ObtenerInstancia().Consultar("SP_OBTENER_BUTACAS_DISPONIBLES", parametros);
            foreach (DataRow r in tabla.Rows)
            {
                int asiento = int.Parse(r["asiento"].ToString());
                int fila = int.Parse(r["fila"].ToString());
                int id = int.Parse(r["id"].ToString());
                string estado = r["estado"].ToString();

                bool estaDisponible = estado == "DESOCUPADO";

                butacas.Add(new Butaca(id, asiento, fila, estaDisponible));
            }
            return butacas;
        }

        public List<Funcion> ObtenerFuncionesPorPelicula(Pelicula pelicula)
        {
            List<Funcion> funciones = new List<Funcion>();
            List<Parametro> parametros = new List<Parametro>();

            parametros.Add(new Parametro("@id_pelicula", pelicula.id_pelicula));
            DataTable tabla = HelperDAO.ObtenerInstancia().Consultar("SP_OBTENER_FUNCIONES_BY_PELICULA");
            foreach (DataRow r in tabla.Rows)
            {
                int id_funcion = int.Parse(r["id_funcion"].ToString());
                int nro_sala = int.Parse(r["nro_sala"].ToString());
                int id_tipo_sala = int.Parse(r["id_tipo_sala"].ToString());
                int id_lenguaje = int.Parse(r["id_lenguaje"].ToString());
                DateTime fecha = DateTime.Parse(r["fecha"].ToString());
                float precio_gral = float.Parse(r["precio_gral"].ToString());
                string tipo_sala = r["tipo_sala"].ToString();
                string lenguaje = r["lenguaje"].ToString();

                Lenguaje l = new Lenguaje(id_lenguaje, lenguaje);
                Sala s = new Sala(nro_sala, new TipoSala(id_tipo_sala, tipo_sala));

                funciones.Add(new Funcion(id_funcion, s,pelicula, l, fecha, precio_gral));
            }
            return funciones;
        }

        public List<Pelicula> ObtenerPeliculas()
        {
            List<Pelicula> peliculas = new List<Pelicula>();

            DataTable tabla = HelperDAO.ObtenerInstancia().Consultar("SP_OBTENER_PELICULAS");
            foreach (DataRow r in tabla.Rows)
            {

                int id = int.Parse(r["id_pelicula"].ToString());
                int duracion = int.Parse(r["duracion"].ToString());
                DateTime fecha_estreno = DateTime.Parse(r["fecha_estreno"].ToString());
                string titulo = r["pelicula"].ToString();

                peliculas.Add(new Pelicula(id,titulo,fecha_estreno,duracion));
            }
            return peliculas;
        }

        public List<TipoSala> ObtenerTiposPorFuncion(Funcion funcion)
        {
            List<TipoSala> tipos_sala = new List<TipoSala>();
            List<Parametro> parametros = new List<Parametro>();

            parametros.Add(new Parametro("@id_funcion", funcion.id));

            DataTable tabla = HelperDAO.ObtenerInstancia().Consultar("sp_obtener_tipos_por_funcion", parametros);
            foreach (DataRow r in tabla.Rows)
            {
                string tipo_sala = r["tipo_sala"].ToString();
                int id_tipo_sala = int.Parse(r["id_tipo_sala"].ToString());

                tipos_sala.Add(new TipoSala(id_tipo_sala, tipo_sala));
            }
            return tipos_sala;
        }
    }
}

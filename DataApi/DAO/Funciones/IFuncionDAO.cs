using DataApi.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataApi.DAO.Funciones
{
    public interface IFuncionDAO
    {
        List<Funcion> ObtenerFuncionesPorPelicula(Pelicula pelicula);
        List<Pelicula> ObtenerPeliculas();
        List<Butaca> ObtenerButacasDisponibles(Funcion funcion);
        List<TipoSala> ObtenerTiposPorFuncion(Funcion funcion);

    }
}

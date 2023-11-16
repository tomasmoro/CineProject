using DataApi.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataApi.DAO.Funciones
{
    public class FuncionesService
    {
        private IFuncionDAO funcionDAO;
        public FuncionesService()
        {
            funcionDAO = new FuncionDAO();
        }

        public List<Funcion> GetFuncionesByPelicula(Pelicula p)
        {
            return funcionDAO.ObtenerFuncionesPorPelicula(p);
        }

        public  List<Butaca> ObtenerButacas(Funcion f)
        {
            return funcionDAO.ObtenerButacasDisponibles(f);
        }

    }
}

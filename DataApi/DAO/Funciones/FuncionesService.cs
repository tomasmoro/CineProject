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

        public void GenerateFactura(Factura newFactura)
        {
            funcionDAO.GenerateFactura(newFactura);
        }

        public List<Cliente> GetClientes()
        {
            return funcionDAO.GetClientes();
        }

        public List<FormaPago> getFormasPago()
        {
            return funcionDAO.GetFormasPago();
        }

        public List<Funcion> GetFuncionesByPelicula(Pelicula p, TipoSala s)
        {
            return funcionDAO.ObtenerFuncionesPorPelicula(p, s);
        }

        public int GetIdButaca(int fila, int asiento, Sala sala)
        {
            return funcionDAO.GetIdButaca(fila, asiento, sala);
        }

        public List<Vendedor> GetVendedores()
        {
            return funcionDAO.GetVendedores();
        }

        public  List<Butaca> ObtenerButacas(Funcion f)
        {
            return funcionDAO.ObtenerButacasDisponibles(f);
        }
        public  List<Pelicula> ObtenerPeliculas()
        {
            return funcionDAO.ObtenerPeliculas();
        }
        public  List<TipoSala> ObtenerTiposPorFuncion(Pelicula p)
        {
            return funcionDAO.ObtenerTiposPorFuncion(p);
        }

    }
}

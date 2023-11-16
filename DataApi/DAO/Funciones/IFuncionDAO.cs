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
        List<Funcion> ObtenerFuncionesPorPelicula(Pelicula pelicula, TipoSala tipo_sala);
        List<Pelicula> ObtenerPeliculas();
        List<Butaca> ObtenerButacasDisponibles(Funcion funcion);
        List<TipoSala> ObtenerTiposPorFuncion(Pelicula pelicula);
        int GetIdButaca(int fila, int asiento, Sala sala);
        List<Vendedor> GetVendedores();
        List<Cliente> GetClientes();
        List<FormaPago> GetFormasPago();
        void GenerateFactura(Factura factura);
    }
}

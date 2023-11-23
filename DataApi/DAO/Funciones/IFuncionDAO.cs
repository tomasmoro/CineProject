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
        List<Funcion> ObtenerFuncionesPorPelicula(int pelicula, int tipo_sala);
        List<Pelicula> ObtenerPeliculas();
        List<Butaca> ObtenerButacasDisponibles(int funcion, int sala);
        List<TipoSala> ObtenerTiposPorFuncion(int pelicula);
        int GetIdButaca(int fila, int asiento, int sala);
        List<Vendedor> GetVendedores();
        List<Cliente> GetClientes();
        List<FormaPago> GetFormasPago();
        int GenerateFactura(Factura factura);
        List<Cliente> GetClientes(int id_cliente);
    }
}

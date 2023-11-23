using DataApi.Dominio;
using System.Collections.Generic;

namespace DataApi.Aplicacion
{
    internal interface IAplicacion
    {
        List<Funcion> ObtenerFuncionesPorPelicula(int pelicula, int tipo_sala);
        List<Pelicula> ObtenerPeliculas();
        List<Butaca> ObtenerButacasDisponibles(int funcion, int s);
        List<TipoSala> ObtenerTiposPorFuncion(int pelicula);
        int GetIdButaca(int fila, int asiento, int sala);
        List<Vendedor> GetVendedores();
        List<Cliente> GetClientes();
        List<FormaPago> GetFormasPago();
        int GenerateFactura(Factura factura);
    }
}
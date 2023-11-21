using DataApi.Aplicacion;
using DataApi.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataApi.DAO.Funciones
{
    public class Aplicacion: IAplicacion
    {
        private IFuncionDAO funcionDAO;
        public Aplicacion()
        {
            funcionDAO = new FuncionDAO();
        }

        public bool GenerateFactura(Factura newFactura)
        {
            return funcionDAO.GenerateFactura(newFactura);
        }

        public List<Cliente> GetClientes()
        {
            return funcionDAO.GetClientes();
        }

        public List<FormaPago> GetFormasPago()
        {
            return funcionDAO.GetFormasPago();
        }

        public List<Funcion> ObtenerFuncionesPorPelicula(int p, int s)
        {
            return funcionDAO.ObtenerFuncionesPorPelicula(p, s);
        }

        public int GetIdButaca(int fila, int asiento, int sala)
        {
            return funcionDAO.GetIdButaca(fila, asiento, sala);
        }

        public List<Vendedor> GetVendedores()
        {
            return funcionDAO.GetVendedores();
        }

        public  List<Butaca> ObtenerButacasDisponibles(int f, int s)
        {
            return funcionDAO.ObtenerButacasDisponibles(f, s);
        }
        public  List<Pelicula> ObtenerPeliculas()
        {
            return funcionDAO.ObtenerPeliculas();
        }
        public  List<TipoSala> ObtenerTiposPorFuncion(int p)
        {
            return funcionDAO.ObtenerTiposPorFuncion(p);
        }

    }
}

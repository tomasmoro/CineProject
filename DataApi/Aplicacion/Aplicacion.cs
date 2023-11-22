using DataApi.Aplicacion;
using DataApi.DAO.Usuarios;
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
        private IClientesDAO clienteDAO;
        public Aplicacion()
        {
            funcionDAO = new FuncionDAO();
            clienteDAO = new UsuariosDAO();
        }

        public bool GenerateFactura(Factura newFactura)
        {
            return funcionDAO.GenerateFactura(newFactura);
        }

        public List<Cliente> GetClientes()
        {
            return funcionDAO.GetClientes();
        }

        public List<Cliente> GetClientes(int id_cliente)
        {
            return funcionDAO.GetClientes(id_cliente);
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

        public List<Butaca> ObtenerButacasDisponibles(int f, int s)
        {
            return funcionDAO.ObtenerButacasDisponibles(f, s);
        }
        public List<Pelicula> ObtenerPeliculas()
        {
            return funcionDAO.ObtenerPeliculas();
        }
        public List<TipoSala> ObtenerTiposPorFuncion(int p)
        {
            return funcionDAO.ObtenerTiposPorFuncion(p);
        }

        public bool CrearCliente(Cliente c)
        {
            return clienteDAO.SaveCliente(c);
        }

        public bool ModificarCliente(Cliente c)
        {
            return clienteDAO.ModificarCliente(c);
        }
        public bool BorrarCliente(Cliente c)
        {
            return clienteDAO.BorrarCliente(c);
        }

        public bool GetUserData(int id_vendedor, string pass)
        {
            return clienteDAO.GetUserData(id_vendedor, pass);
        }
    }
}

using DataApi.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataApi.DAO.Usuarios
{
    internal interface IClientesDAO
    {
        List<Cliente> ObtenerCliente();

        bool SaveCliente(Cliente cliente);
    }
}

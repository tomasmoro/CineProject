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
        bool BorrarCliente(Cliente c);
        bool ModificarCliente(Cliente c);
        bool SaveCliente(Cliente cliente);
    }
}

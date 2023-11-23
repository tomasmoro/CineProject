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
        bool CheckTicket(QrSendModel qr);
        bool GetUserData(int id_vendedor, string pass);
        bool ModificarCliente(Cliente c);
        bool SaveCliente(Cliente cliente);
    }
}

using DataApi.Dominio;
using DataAPI.Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataApi.DAO.Usuarios
{
    internal class UsuariosDAO : IClientesDAO
    {
        public bool SaveCliente(Cliente cliente)
        {
            bool resultado = true;
            SqlConnection conexion = HelperDAO.ObtenerInstancia().ObtenerConexion();
            conexion.Open();
            SqlCommand comando = new SqlCommand("SP_INGRESAR_CLIENTES", conexion);
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@id_cliente", cliente.id_cliente);
            comando.Parameters.AddWithValue("@nombre", cliente.nombre);
            comando.Parameters.AddWithValue("@apellido", cliente.apellido);
            comando.Parameters.AddWithValue("@fecha_nacimiento", cliente.fecha_nacimiento);
            comando.Parameters.AddWithValue("@mail", cliente.mail);
            comando.Parameters.AddWithValue("@telefono", cliente.telefono);

            comando.ExecuteNonQuery();
            conexion.Close();

            return true;
        }
        public bool BorrarCliente(Cliente cliente)
        {
            bool resultado = true;
            SqlConnection conexion = HelperDAO.ObtenerInstancia().ObtenerConexion();
            conexion.Open();
            SqlCommand comando = new SqlCommand("SP_BORRAR_CLIENTE", conexion);
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@id_cliente", cliente.id_cliente);
            comando.ExecuteNonQuery();
            conexion.Close();

            return true;
        }

        public bool ModificarCliente(Cliente cliente)
        {
            bool resultado = true;
            SqlConnection conexion = HelperDAO.ObtenerInstancia().ObtenerConexion();
            conexion.Open();
            SqlCommand comando = new SqlCommand("sp_Update_Cliente", conexion);
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@IdCliente", cliente.id_cliente);
            comando.Parameters.AddWithValue("@NuevoNombre", cliente.nombre);
            comando.Parameters.AddWithValue("@NuevoApellido", cliente.apellido);
            comando.Parameters.AddWithValue("@NuevoCorreo", cliente.mail);
            comando.Parameters.AddWithValue("@NuevaFecha", cliente.fecha_nacimiento);
            comando.Parameters.AddWithValue("@NuevoTel", cliente.telefono);

            comando.ExecuteNonQuery();
            conexion.Close();

            return true;
        }

        public bool GetUserData(int id_vendedor, string pass)
        {
           
                bool resultado = true;
                SqlConnection conexion = HelperDAO.ObtenerInstancia().ObtenerConexion();
                conexion.Close();
                conexion.Open();
                SqlCommand comando = new SqlCommand("SP_LOGIN", conexion);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@idusuario", id_vendedor);
                comando.Parameters.AddWithValue("@clave", pass);

                SqlParameter parametro = new SqlParameter();
                parametro.ParameterName = "@bool";
                parametro.SqlDbType = SqlDbType.Bit;
                parametro.Direction = ParameterDirection.Output;
                comando.Parameters.Add(parametro);
                comando.ExecuteNonQuery();

                bool res = (bool)parametro.Value;

                conexion.Close();

                return res;
            
        }
    }
}

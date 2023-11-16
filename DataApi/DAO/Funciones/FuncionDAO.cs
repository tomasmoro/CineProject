using DataApi.Dominio;
using DataAPI.Datos;
using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataApi.DAO.Funciones
{
    public class FuncionDAO : IFuncionDAO
    {
        public void GenerateFactura(Factura factura)
        {
            SqlTransaction transaccion = null;
            SqlConnection conexion = HelperDAO.ObtenerInstancia().ObtenerConexion();
            try
            {
                conexion.Open();
                //Abro la conexion y despues abro la transaccion bajo esa conexion!
                transaccion = conexion.BeginTransaction();
                //Al crear el comando le pasamos x parametro: el string del comando, la conexion y la transaccion
                SqlCommand comando = new SqlCommand("SP_INSERTAR_COMPROBANTES", conexion, transaccion);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@fecha", factura.fecha);
                comando.Parameters.AddWithValue("@vendedor", factura.vendedor.id);
                comando.Parameters.AddWithValue("@cliente", factura.cliente.id);
                comando.Parameters.AddWithValue("@funcion", factura.funcion.id);
                comando.Parameters.AddWithValue("@forma_pago", factura.formaPago.id);
                comando.ExecuteNonQuery();

                int i = 1;
                foreach (TicketDetalle d in factura.tickets)
                {
                    SqlCommand comandoCarga = new SqlCommand("INSERTAR_TICKET", conexion, transaccion);
                    comandoCarga.CommandType = CommandType.StoredProcedure;
                    comandoCarga.Parameters.AddWithValue("@comprobante", factura.nro_factura);
                    comandoCarga.Parameters.AddWithValue("@butaca_sala", d.butaca.id);
                    comandoCarga.Parameters.AddWithValue("@total", d.total);
                    comandoCarga.ExecuteNonQuery();
                    i++;
                }
                transaccion.Commit();
            }
            catch
            {
                if (transaccion != null)
                {
                    transaccion.Rollback();
                }
            }
            finally
            {
                if (conexion != null && conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
        }

        public List<Cliente> GetClientes()
        {
            List<Cliente> clientes = new List<Cliente>();

            DataTable tabla = HelperDAO.ObtenerInstancia().Consultar("sp_obtener_clientes");
            foreach (DataRow r in tabla.Rows)
            {
                int id = int.Parse(r["id_cliente"].ToString());
                string nombre = r["nombre"].ToString();
                string apellido = r["apellido"].ToString();


                clientes.Add(new Cliente(id, nombre, apellido));
            }
            return clientes;
        }

        public List<FormaPago> GetFormasPago()
        {
            List<FormaPago> fp = new List<FormaPago>();

            DataTable tabla = HelperDAO.ObtenerInstancia().Consultar("SP_MOSTRAR_FORMAS_PAGO");
            foreach (DataRow r in tabla.Rows)
            {
                int id = int.Parse(r["id_forma_pago"].ToString());
                string nombre = r["forma_pago"].ToString();

                fp.Add(new FormaPago(id, nombre));
            }
            return fp;
        }

        public int GetIdButaca(int fila, int asiento, Sala sala)
        {
            List<Parametro> parametros = new List<Parametro>();

            parametros.Add(new Parametro("@fila", fila));
            parametros.Add(new Parametro("@asiento", asiento));
            parametros.Add(new Parametro("@sala", sala.id));

            int resultado = HelperDAO.ObtenerInstancia().ObtenerEscalar("OBTENER_BUTACA", parametros, "id");
            return resultado;
        }

        public List<Vendedor> GetVendedores()
        {
            List<Vendedor> vendedores = new List<Vendedor>();

            DataTable tabla = HelperDAO.ObtenerInstancia().Consultar("SP_MOSTRAR_VENDEDORES");
            foreach (DataRow r in tabla.Rows)
            {
                int id = int.Parse(r["id_vendedor"].ToString());
                string nombre = r["nombre"].ToString();
                string apellido = r["apellido"].ToString();


                vendedores.Add(new Vendedor(id, nombre, apellido));
            }
            return vendedores;
        }

        public List<Butaca> ObtenerButacasDisponibles(Funcion funcion)
        {
            List<Butaca> butacas = new List<Butaca>();
            List<Parametro> parametros = new List<Parametro>();

            parametros.Add(new Parametro("@id_funcion", funcion.id));
            parametros.Add(new Parametro("@id_sala", funcion.sala.id));
                
            DataTable tabla = HelperDAO.ObtenerInstancia().Consultar("SP_OBTENER_BUTACAS_DISPONIBLES", parametros);
            foreach (DataRow r in tabla.Rows)
            {
                int asiento = int.Parse(r["asiento"].ToString());
                int fila = int.Parse(r["fila"].ToString());
                int id = int.Parse(r["id"].ToString());
                string estado = r["estado"].ToString();

                bool estaDisponible = estado == "DESOCUPADO";

                butacas.Add(new Butaca(id, asiento, fila, estaDisponible));
            }
            return butacas;
        }

        public List<Funcion> ObtenerFuncionesPorPelicula(Pelicula pelicula, TipoSala tipoSala)
        {
            List<Funcion> funciones = new List<Funcion>();
            List<Parametro> parametros = new List<Parametro>();

            parametros.Add(new Parametro("@id_pelicula", pelicula.id_pelicula));
            parametros.Add(new Parametro("@id_tipo_sala", tipoSala.Id_tipo_sala));
            DataTable tabla = HelperDAO.ObtenerInstancia().Consultar("SP_OBTENER_FUNCIONES_BY_PELICULA", parametros);
            foreach (DataRow r in tabla.Rows)
            {
                int id_funcion = int.Parse(r["id"].ToString());
                int nro_sala = int.Parse(r["nro_sala"].ToString());
                int id_tipo_sala = int.Parse(r["id_tipo_sala"].ToString());
                int id_lenguaje = int.Parse(r["id_lenguaje"].ToString());
                DateTime fecha = DateTime.Parse(r["fecha"].ToString());
                float precio_gral = float.Parse(r["precio_gral"].ToString());
                string tipo_sala = r["tipo_sala"].ToString();
                string lenguaje = r["lenguaje"].ToString();

                Lenguaje l = new Lenguaje(id_lenguaje, lenguaje);
                Sala s = new Sala(nro_sala, new TipoSala(id_tipo_sala, tipo_sala));

                funciones.Add(new Funcion(id_funcion, s,pelicula, l, fecha, precio_gral));
            }
            return funciones;
        }

        public List<Pelicula> ObtenerPeliculas()
        {
            List<Pelicula> peliculas = new List<Pelicula>();

            DataTable tabla = HelperDAO.ObtenerInstancia().Consultar("SP_OBTENER_PELICULAS");
            foreach (DataRow r in tabla.Rows)
            {

                int id = int.Parse(r["id_pelicula"].ToString());
                int duracion = int.Parse(r["duracion"].ToString());
                DateTime fecha_estreno = DateTime.Parse(r["fecha_estreno"].ToString());
                string titulo = r["pelicula"].ToString();

                peliculas.Add(new Pelicula(id,titulo,fecha_estreno,duracion));
            }
            return peliculas;
        }

        public List<TipoSala> ObtenerTiposPorFuncion(Pelicula pelicula)
        {
            List<TipoSala> tipos_sala = new List<TipoSala>();
            List<Parametro> parametros = new List<Parametro>();

            parametros.Add(new Parametro("@id_pelicula", pelicula.id_pelicula));

            DataTable tabla = HelperDAO.ObtenerInstancia().Consultar("sp_obtener_tipos_por_funcion", parametros);
            foreach (DataRow r in tabla.Rows)
            {
                string tipo_sala = r["tipo_sala"].ToString();
                int id_tipo_sala = int.Parse(r["id_tipo_sala"].ToString());

                tipos_sala.Add(new TipoSala(id_tipo_sala, tipo_sala));
            }
            return tipos_sala;
        }
    }
}

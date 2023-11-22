using Microsoft.AspNetCore.Mvc;
using DataApi.Dominio;
using DataApi.DAO.Funciones;

namespace ApiCine.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class CineController : ControllerBase
    {


        private Aplicacion app;

        public CineController()
        {
            app = new Aplicacion();
        }

        // GET: api/<PresupuestoController>
        [HttpGet("/peliculas/{id_pelicula}/{id_tipo_sala}")]
        public IActionResult ObtenerFuncionesPorPelicula(int id_pelicula, int id_tipo_sala)
        {

            List<Funcion> lst = null;
            try
            {
                lst = app.ObtenerFuncionesPorPelicula(id_pelicula, id_tipo_sala);
                return Ok(lst);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error interno!!! Intente luego...");
            }
        }

        // GET: api/<PresupuestoController>
        [HttpGet("/butacas/{id_funcion}/{id_sala}")]
        public IActionResult ObtenerButacasDisponibles(int id_funcion, int id_sala)
        {

            List<Butaca> lst = null;
            try
            {
                lst = app.ObtenerButacasDisponibles(id_funcion, id_sala);
                return Ok(lst);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error interno!!! Intente luego...");
            }
        }

        // GET: api/<PresupuestoController>
        [HttpGet("/asientos/{asiento}/{fila}/{nro_sala}")]
        public IActionResult GetIdButaca(int asiento, int fila, int nro_sala)
        {

            Int32 resultado = -1;
            try
            {
                resultado = app.GetIdButaca(fila, asiento, nro_sala);
                if (resultado != -1)
                    return Ok(resultado);
                else
                    return BadRequest("No se encontro la butaca");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error interno!!! Intente luego...");
            }
        }

        // GET: api/<PresupuestoController>
        [HttpGet("/tipo_sala/{id_pelicula}")]
        public IActionResult ObtenerTiposPorFuncion(int id_pelicula)
        {

            List<TipoSala> lst = null;
            try
            {
                lst = app.ObtenerTiposPorFuncion(id_pelicula);

                return Ok(lst);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error interno!!! Intente luego...");
            }
        }

        // GET: api/<PresupuestoController>
        [HttpGet("/vendedores")]
        public IActionResult GetVendedores()
        {

            List<Vendedor> lst = null;
            try
            {
                lst = app.GetVendedores();
                return Ok(lst);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error interno!!! Intente luego...");
            }
        }
        // GET: api/<PresupuestoController>
        [HttpGet("/clientes")]
        public IActionResult GetClientes()
        {

            List<Cliente> lst = null;
            try
            {
                lst = app.GetClientes();
                return Ok(lst);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error interno!!! Intente luego...");
            }
        }
        // GET: api/<PresupuestoController>
        [HttpGet("/clientes/{id_cliente}")]
        public IActionResult GetClientes(int id_cliente)
        {

            List<Cliente> lst = null;
            try
            {
                lst = app.GetClientes(id_cliente);
                return Ok(lst);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error interno!!! Intente luego...");
            }
        }
        // GET: api/<PresupuestoController>
        [HttpGet("/formapago")]
        public IActionResult GetFormasPago()
        {

            List<FormaPago> lst = null;
            try
            {
                lst = app.GetFormasPago();
                return Ok(lst);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error interno!!! Intente luego...");
            }
        }

        // POST: api/<PresupuestoController>
        [HttpPost("/comprobante")]
        public IActionResult SetComprobante(Factura f)
        {
            try
            {
                if (f != null)
                {

                    bool result = app.GenerateFactura(f);
                    if (result)
                        return Ok("Se añadio correctamente!!");
                    else return BadRequest("Error interno!!!");
                }

                return BadRequest("EL objeto es invalido!");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error interno!!! Intente luego...");
            }
        }
        // POST: api/<PresupuestoController>
        [HttpPost("/clientes")]
        public IActionResult SetCliente(Cliente c)
        {
            try
            {
                if (c != null)
                {

                    bool result = app.CrearCliente(c);
                    if (result)
                        return Ok("Se añadio correctamente!!");
                    else return BadRequest("Error interno!!!");
                }

                return BadRequest("EL objeto es invalido!");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error interno!!! Intente luego...");
            }
        }        // POST: api/<PresupuestoController>

        [HttpPut("/clientes")]
        public IActionResult putCliente(Cliente c)
        {
            try
            {
                if (c != null)
                {

                    bool result = app.ModificarCliente(c);
                    if (result)
                        return Ok("Se modificó correctamente!!");
                    else return BadRequest("Error interno!!!");
                }

                return BadRequest("EL objeto es invalido!");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error interno!!! Intente luego...");
            }
        }
        [HttpPost("/del_clientes")]
        public IActionResult deleteCliente(Cliente c)
        {
            try
            {
                if (c != null)
                {

                    bool result = app.BorrarCliente(c);
                    if (result)
                        return Ok("Se eliminó correctamente!!");
                    else return BadRequest("Error interno!!!");
                }

                return BadRequest("EL objeto es invalido!");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error interno!!! Intente luego...");
            }
        }
        // GET: api/<PresupuestoController>
        [HttpGet("/usuario/{id_vendedor}/{pass}")]
        public IActionResult GetUserData(int id_vendedor, string pass)
        {

            try
            {
                bool resultado = app.GetUserData(id_vendedor, pass);
                return Ok(resultado);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error interno!!! Intente luego...");
            }
        }
    }
}

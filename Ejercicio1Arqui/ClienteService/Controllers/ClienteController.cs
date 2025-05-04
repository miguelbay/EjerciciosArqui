using Microsoft.AspNetCore.Mvc;

namespace ClienteService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private static readonly List<Cliente> Clientes = new List<Cliente>
        {
            new Cliente { Cedula = "123456789", Nombre = "Andres Cano", Direccion = "Bronx", Telefono = "3156421831" },
            new Cliente { Cedula = "23456789", Nombre = "Nicolas Hincapie", Direccion = "Calle Real 100", Telefono = "3114236543" },
            new Cliente { Cedula = "3456789", Nombre = "Miguel Bayona", Direccion = "Calle Real 300", Telefono = "312435546" },
            new Cliente { Cedula = "87654321", Nombre = "Julian Rodriguez ", Direccion = "Calle Real 200", Telefono = "317335546" },
            new Cliente { Cedula = "7654321", Nombre = "Juan Morales", Direccion = "Calle Real 400", Telefono = "318495886" },
            new Cliente { Cedula = "987654321", Nombre = "Juan Rincon", Direccion = "Calle Real 500", Telefono = "3214364242" }
        };

        [HttpGet("{cedula}")]
        public IActionResult GetCliente(string cedula)
        {
            var cliente = Clientes.FirstOrDefault(c => c.Cedula == cedula);
            if (cliente == null)
            {
                return NotFound(new { error = "Cliente no encontrado" });
            }
            return Ok(cliente);
        }
    }
}

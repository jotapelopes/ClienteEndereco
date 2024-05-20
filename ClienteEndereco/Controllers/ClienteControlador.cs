using ClienteEndereco.DTO;
using ClienteEndereco.Model;
using ClienteEnderecoApp;
using Microsoft.AspNetCore.Mvc;

namespace ClienteEndereco.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly DataContext _context;

        public ClienteController(DataContext context)
        {
            _context = context;
        }

        // GET: api/<ClienteController>
        [HttpGet]
        public ActionResult<List<Cliente>> Get()
        {
            var clientes = _context.Clientes.ToList();
            return clientes;
        }

        // GET api/<ClienteController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return _context.Clientes.Find(id).Nome;
        }

        // POST api/<ClienteController>
        [HttpPost]
        public ActionResult<Cliente> Post([FromBody] ClienteRequest clienteRequest)
        {
            if (ModelState.IsValid)
            {
                var clientes = clienteRequest.toModel();
                _context.Clientes.Add(clientes);
                _context.SaveChanges();

                return clientes;

            }

            return BadRequest(ModelState);
        }

    }
}

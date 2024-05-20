using ClienteEndereco.DTO;
using ClienteEndereco.Model;
using ClienteEnderecoApp;
using Microsoft.AspNetCore.Mvc;

namespace ClienteEndereco.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnderecoController : ControllerBase
    {
        private readonly DataContext _context;

        public EnderecoController(DataContext context)
        {
            _context = context;
        }

        // GET: api/<EnderecoController>
        [HttpGet]
        public ActionResult<List<Endereco>> Get()
        {
            var enderecos = _context.Enderecos.ToList();
            return enderecos;
        }

        // GET api/<EnderecoController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return _context.Enderecos.Find(id).Rua;
        }

        // POST api/<EnderecoController>
        [HttpPost]
        public ActionResult<Endereco> Post([FromBody] EnderecoRequest enderecoRequest)
        {
            if (ModelState.IsValid)
            {
                var endereco = enderecoRequest.toModel();
                _context.Enderecos.Add(endereco);
                _context.SaveChanges();

                return endereco;

            }

            return BadRequest(ModelState);
        }

    }
}

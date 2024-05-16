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
        public ActionResult<Endereco> Get(int id)
        {
            var endereco = _context.Enderecos.Find(id);
            if (endereco == null)
            {
                return NotFound();
            }
            return endereco;
        }

        // POST api/<EnderecoController>
        [HttpPost]
        public ActionResult<Endereco> Post(Endereco endereco)
        {
            if (ModelState.IsValid)
            {
                _context.Enderecos.Add(endereco);
                _context.SaveChanges();
                return endereco;
            }
            return BadRequest(ModelState);
        }

        // PUT api/<EnderecoController>/5
        [HttpPut("{id}")]
        public ActionResult<Endereco> Put(int id, Endereco endereco)
        {
            if (id != endereco.EnderecoId)
            {
                return BadRequest();
            }

            _context.Entry(endereco).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return endereco;
        }

        // DELETE api/<EnderecoController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var endereco = _context.Enderecos.Find(id);
            if (endereco == null)
            {
                return NotFound();
            }

            _context.Enderecos.Remove(endereco);
            _context.SaveChanges();
            return Ok();
        }
    }
}

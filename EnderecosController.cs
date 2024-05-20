using P1Navarro.Context;
using P1Navarro.DTO;
using P1Navarro.Model;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace P1Navarro.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnderecosController : ControllerBase
    {

        private readonly DataContext _dataContext;

        public EnderecosController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        // GET: api/<EnderecosController>
        [HttpGet]
        public ActionResult<List<Endereco>> Get()
        {
            return _dataContext.Enderecos.ToList();
        }

        // GET api/<EnderecosController>/5
        [HttpGet("{id}")]
        public ActionResult<Endereco> Get(int id)
        {
            var endereco = _dataContext.Enderecos.FirstOrDefault(x => x.Id == id);
            if (endereco == null)
            {
                return BadRequest("ID não existente");
            }
            return endereco;
        }

        // POST api/<EnderecosController>
        [HttpPost]
        public ActionResult<Endereco> Post([FromBody] EnderecoRequest enderecoRequest)
        {
            if (ModelState.IsValid)
            {
                var endereco = enderecoRequest.ToModel();
                _dataContext.Enderecos.Add(endereco);
                _dataContext.SaveChanges();
                return endereco;
            }
            return BadRequest(ModelState);
        }

        // PUT api/<EnderecosController>/5
        [HttpPut("{id}")]
        public ActionResult<Endereco> Put(int id, [FromBody] EnderecoRequest enderecoRequest)
        {
            var endereco = _dataContext.Enderecos.FirstOrDefault(x => x.Id == id);
            if (endereco == null)
            {
                return BadRequest("ID não existente");
            }

            if (ModelState.IsValid)
            {
                endereco.Rua = enderecoRequest.Rua;
                endereco.Cidade = enderecoRequest.Cidade;
                endereco.Estado = enderecoRequest.Estado;
                endereco.CEP = enderecoRequest.CEP;

                _dataContext.SaveChanges();
                return endereco;
            }
            return BadRequest(ModelState);
        }

        // DELETE api/<EnderecosController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var endereco = _dataContext.Enderecos.FirstOrDefault(x => x.Id == id);
            if (endereco == null)
            {
                return BadRequest("ID não existente");
            }

            _dataContext.Enderecos.Remove(endereco);
            _dataContext.SaveChanges();
            return NoContent();
        }
    }
}

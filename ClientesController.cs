using Microsoft.AspNetCore.Mvc;
using P1Navarro.Context;
using P1Navarro.DTO;
using P1Navarro.Model;
using System.Collections.Generic;
using System.Linq;

namespace P1Navarro.Controllers
{
    [ApiController]
    [Route("/api/v1.0/cliente")]
    public class ClienteController : ControllerBase
    {

        private readonly DataContext _dataContext;

        public ClienteController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        [HttpPost]
        public ActionResult<Cliente> Post([FromBody] ClienteRequest clienteRequest)
        {
            if (ModelState.IsValid)
            {
                var cliente = clienteRequest.ToModel();
                _dataContext.Clientes.Add(cliente);
                _dataContext.SaveChanges();
                return cliente;
            }
            return BadRequest(ModelState);
        }

        [HttpGet]
        public ActionResult<List<Cliente>> Get()
        {
            return _dataContext.Clientes.ToList();
        }

        [HttpPut]
        public ActionResult<Cliente> Put([FromBody] Cliente cliente)
        {
            var existingCliente = _dataContext.Clientes.FirstOrDefault(c => c.Id == cliente.Id);
            if (existingCliente == null)
            {
                ModelState.AddModelError("ClienteId", "Id do cliente não encontrado!");
                return BadRequest(ModelState);
            }

            if (ModelState.IsValid)
            {
                existingCliente.Nome = cliente.Nome;
                existingCliente.Email = cliente.Email;
                existingCliente.Telefone = cliente.Telefone;

                _dataContext.SaveChanges();
                return existingCliente;
            }
            return BadRequest(ModelState);
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var cliente = _dataContext.Clientes.Find(id);
            if (cliente == null)
            {
                ModelState.AddModelError("ClienteId", "Id do cliente não encontrado!");
                return BadRequest(ModelState);
            }

            _dataContext.Clientes.Remove(cliente);
            _dataContext.SaveChanges();
            return Ok();
        }
    }
}

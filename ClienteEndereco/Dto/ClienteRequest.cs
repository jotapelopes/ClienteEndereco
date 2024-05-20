using ClienteEndereco.Model;
using System.ComponentModel.DataAnnotations;

namespace ClienteEndereco.DTO
{
    public class ClienteRequest
    {
        [Required]
        public string Nome { get; set; }

        public Cliente toModel()
            => new Cliente(Nome);
    }
}
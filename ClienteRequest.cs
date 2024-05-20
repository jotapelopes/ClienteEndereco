using P1Navarro.Model;
using System.ComponentModel.DataAnnotations;

namespace P1Navarro.DTO
{
    public class ClienteRequest
    {
        [Required]
        public string Nome { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Telefone { get; set; }

        public Cliente toModel()
            => new Cliente(Nome, Email, Telefone);
    }
}

using ClienteEndereco.Model;
using System.ComponentModel.DataAnnotations;

namespace ClienteEndereco.DTO
{
    public class EnderecoRequest
    {
        [Required]
        public string Rua { get; set; }

        [Required]
        public int Cep { get; set; }

        [Required]
        public int Numero { get; set; }

        [Required]
        public int ClienteId { get; set; }

        public Endereco toModel()
            => new Endereco(Rua, Cep, Numero, ClienteId);
    }
}
using P1Navarro.Model;
using System.ComponentModel.DataAnnotations;

namespace P1Navarro.DTO
{
    public class EnderecoRequest
    {
        [Required]
        public string Rua { get; set; }

        [Required]
        public string Cidade { get; set; }

        [Required]
        public string Estado { get; set; }

        [Required]
        public string CEP { get; set; }

        [Required]
        public int ClienteId { get; set; }

        public Endereco toModel()
            => new Endereco(Rua, Cidade, Estado, CEP, ClienteId);
    }
}

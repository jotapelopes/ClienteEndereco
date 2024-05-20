using System.ComponentModel.DataAnnotations;

namespace P1Navarro.Model
{
    public class Endereco
    {
        [Key]
        public int Id { get; set; }
        public string Rua { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string CEP { get; set; }
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }

        public Endereco(string rua, string cidade, string estado, string cep, int clienteId)
        {
            Rua = rua;
            Cidade = cidade;
            Estado = estado;
            CEP = cep;
            ClienteId = clienteId;
        }
    }
}


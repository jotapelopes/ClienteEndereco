using System.ComponentModel.DataAnnotations;

namespace ClienteEndereco.Model
{
    public class Endereco
    {
        [Key]
        public int Id { get; set; }
        public string Rua { get; set; }

        public int Cep { get; set; }

        public int Numero { get; set; }

        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }

        public Endereco(string rua, int cep, int numero, int clienteId)
        {
            Rua = rua;
            Cep = cep;
            Numero = numero;
            ClienteId = clienteId;
        }
    }
}

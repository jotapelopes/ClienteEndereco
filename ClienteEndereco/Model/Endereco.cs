using System.ComponentModel.DataAnnotations;

namespace ClienteEndereco.Model
{
    public class Endereco
    {
        [Key]
        public int Id { get; set; }
        public string Rua { get; set; }
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
        public int EnderecoId { get; internal set; }

        public Endereco(string rua, int clienteId)
        {
            Rua = rua;
            ClienteId = clienteId;
        }
    }
}

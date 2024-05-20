using ClienteEndereco.Model;

namespace ClienteEndereco.DTO
{
    public class EnderecoResponse
    {
        public string Rua { get; set; }
        public int Cep { get; set; }
        public int Numero { get; set; }
        public Cliente Cliente { get; set; }

        public EnderecoResponse(Endereco endereco)
        {
            Rua = endereco.Rua;
            Cep = endereco.Cep;
            Numero = endereco.Numero;
            Cliente = endereco.Cliente;
        }
    }
}
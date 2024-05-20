using P1Navarro.Model;

namespace P1Navarro.DTO
{
    public class EnderecoResponse
    {
        public string Rua { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string CEP { get; set; }
        public Cliente Cliente { get; set; }

        public EnderecoResponse(Endereco endereco)
        {
            Rua = endereco.Rua;
            Cidade = endereco.Cidade;
            Estado = endereco.Estado;
            CEP = endereco.CEP;
            Cliente = endereco.Cliente;
        }
    }
}

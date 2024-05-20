using Systeusing System.ComponentModel.DataAnnotations;

namespace P1Navarro.Model
{
    public class Cliente
    {
        private string? nome;

        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }

        public Cliente(string nome, string email, string telefone)
        {
            Nome = nome;
            Email = email;
            Telefone = telefone;
        }
    }
}


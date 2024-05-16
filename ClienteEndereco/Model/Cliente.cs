using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ClienteEndereco.Model
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }

        public Cliente(string nome)
        {
            Nome = nome;
        }
    }
}
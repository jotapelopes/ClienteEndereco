using Microsoft.EntityFrameworkCore;
using ClienteEndereco.Model;

namespace ClienteEnderecoApp
{
    public class DataContext : DbContext
    {
        public DataContext() : base()
        { }

        public DataContext(DbContextOptions options) : base(options)
        { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer
                ("Password=root;Persist Security Info=True;User ID=root;Initial Catalog=ClienteEnderecoDB;Data Source=server");
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
    }
}

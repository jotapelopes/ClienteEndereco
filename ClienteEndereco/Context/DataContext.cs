using Microsoft.EntityFrameworkCore;
using ClienteEndereco.Model;

namespace ClienteEnderecoApp
{
    public class DataContext : DbContext
    {
      
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=EcommerceDB;ConnectRetryCount=0");
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
    }
}

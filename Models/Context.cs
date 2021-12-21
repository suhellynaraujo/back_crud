using back_crud.Models;
using Microsoft.EntityFrameworkCore;

namespace back_crud.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }
        public DbSet<Destino> Destino { get; set; }

        public DbSet<Promocoes> Promocoes { get; set; }

        public DbSet<Contato> Contato { get; set; }

        public DbSet<Entrar> Entrar { get; set; }   

        public DbSet<Cadastro> Cadastro { get; set; } 

        public DbSet<Pesquisar> Pesquisar { get; set; }
    
    }
}

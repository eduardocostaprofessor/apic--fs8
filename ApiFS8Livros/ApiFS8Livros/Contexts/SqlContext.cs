using ApiFS8Livros.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiFS8Livros.Contexts
{
    public class SqlContext : DbContext
    {
        public SqlContext() { }
        public SqlContext(DbContextOptions<SqlContext> options) : base(options) { }

        // vamos utilizar esse método para configurar o banco de dados
        protected override void
         OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // cada provedor tem sua sintaxe para especificação

               
                optionsBuilder.UseSqlServer("Data Source = DESKTOP-HMM1EPQ\\SQLEXPRESS; initial catalog = Chapter; user id = sa; password = sql@134");



                //optionsBuilder.UseSqlServer("Data Source = DESKTOP-HMM1EPQ\\SQLEXPRESS; initial catalog = Chapter; user id = sa; password = sql@134");
                //optionsBuilder.UseSqlServer("Data Source = DESKTOP-HMM1EPQ\SQLEXPRESS; initial catalog = Chapter; Integrated Security = true; TrustServerCertificate=True");
                //optionsBuilder.UseSqlServer("Data Source = DESKTOP-HMM1EPQ\SQLEXPRESS; initial catalog = Chapter; Integrated Security = true");
            }
        }
        // dbset representa as entidades que serão utilizadas nas operações de leitura, criação, atualização e deleção
        public DbSet<Livro> Livros { get; set; }

    }
}

using Emprestimo_Livros.Models;
using Microsoft.EntityFrameworkCore;

namespace Emprestimo_Livros.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {
            
        }

        //Estrutura da tabela
        public DbSet<EmprestimosModel> Emprestimos { get; set; }
    }
}

using Microsoft.EntityFrameworkCore;
namespace ProjV2.Models
{
    public class ProjetoVendaContext : DbContext
    {
    public  ProjetoVendaContext(DbContextOptions<ProjetoVendaContext> options) : base(options)
       {

       }
       public DbSet<Funcionario> Funcionarios {get; set; }
       public DbSet<Servico> Servicos {get; set; }
    }
}
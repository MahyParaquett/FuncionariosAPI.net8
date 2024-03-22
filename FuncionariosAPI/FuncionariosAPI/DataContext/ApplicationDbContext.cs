using FuncionariosAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace FuncionariosAPI.DataContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options) : base(options)
        {
        }
        //Quando ele rodar, vai criar uma tabela dentro do Banco com a estrutura do funcionárioModel
        public DbSet<FuncionarioModel> Funcionarios {  get; set; }
    }
}

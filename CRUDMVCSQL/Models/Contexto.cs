using Microsoft.EntityFrameworkCore;

namespace CRUDMVCSQL.Models
{
    public class Contexto : DbContext
    {
        //Criando o método construtor
        public Contexto(DbContextOptions<Contexto> options) : base(options) 
        {
            
            
        }

        //Definindo o DbSet, dizer para o Entityframework quais modelos eu quero que ele gerencie, se nao existir no banco, ele ira criar com o migration
        public DbSet<Aluno> Aluno { get; set; }
    }
}

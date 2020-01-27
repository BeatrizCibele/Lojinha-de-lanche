using LanchesPage.Models;
using Microsoft.EntityFrameworkCore;

namespace LanchesPage.Context
{
    public class AppDbContext: DbContext
    {
        //Colocar no construtor o DbContext options com o tipo da classe AppDbContext e atribuir a classe base
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { }

        //Defnir as propriedades onde vai mapear as tabelas 
        //As propriedades servem para informar ao Entity quais entidades se quer mapear
        public DbSet<Lanche> Lanches { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<CarrinhoCompraItem> CarrinhoCompraItens { get; set; }


    }
}

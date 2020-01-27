using LanchesPage.Models;
using LanchesPage.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanchesPage.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly AppDbContext _contexto;

        //Precisa criar um construtor para injecao de dependencias em Categoria
        public CategoriaRepository(AppDbContext contexto)
        {
            _contexto = contexto;
           
        }
        public IEnumerable<Categoria> Categorias => _contexto.Categorias; 
        
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LanchesPage.Models;
using LanchesPage.Context;
using Microsoft.EntityFrameworkCore;

namespace LanchesPage.Repositories
{
    public class LancheRepository: ILancheRepository
    {
        private readonly AppDbContext _contexto;

        public LancheRepository(AppDbContext contexto)
        {
            _contexto = contexto;
        }

        public IEnumerable<Lanche> Lanches => _contexto.Lanches.Include(c => c.Categoria);
        
        IEnumerable<Lanche> ILancheRepository.LanchesPreferidos => 
          _contexto.Lanches.Where(p => p.isLanchePreferido).Include(c => c.Categoria);

        public Lanche GetLancheById(int lancheId)
        {
           return _contexto.Lanches.FirstOrDefault(l => l.LancheId == lancheId);
           
        }
    }
}

using Microsoft.EntityFrameworkCore;
using LanchesPage.Repositories;
using Microsoft.AspNetCore.Mvc;
using LanchesPage.ViewModels;
using LanchesPage.Models;
using System.Collections.Generic;
using System.Linq;

namespace LanchesPage.Controllers
{
    public class LancheController : Controller
    {
        private readonly ICategoriaRepository _categoriaRepository;
        private readonly ILancheRepository _lancheRepository;

        public LancheController(ICategoriaRepository categoriaRepository, ILancheRepository lancheRepository)
        {
            _categoriaRepository = categoriaRepository;
            _lancheRepository = lancheRepository;
            
        }
        
        public IActionResult List(string categoria)
        {   
            //Removido
        //    ViewBag.Lanche = "Lanches";
        //    ViewData["Categoria"] = "Categoria";

            string _categoria = categoria;
            IEnumerable<Lanche> lanches;

            string categoriaAtual = string.Empty;

            if (string.IsNullOrEmpty(categoria))
            {
                lanches = _lancheRepository.Lanches.OrderBy(l => l.LancheId);
                categoria = "Todos os lanches";
            }
            else
            {
                if (string.Equals("Normal",_categoria, System.StringComparison.OrdinalIgnoreCase))
                {
                    lanches = _lancheRepository.Lanches.Where(l => l.Categoria.CategoriaNome.Equals("Normal")).OrderBy(l => l.Nome);
                }
                else
                {
                    lanches = _lancheRepository.Lanches.Where(l=> l.Categoria.CategoriaNome.Equals("Natural")).OrderBy(l=>l.Nome);
                }

                categoriaAtual = _categoria;
            }
            //var lanches = _lancheRepository.Lanches;
            //return View(lanches);

            //Agora, invés de retornar uma relação de lanches baseada na Model agora está:
            //Criando uma instância na ViewModel
            //Obtendo os lanches
            //Atribuindo a propriedade de lanches a viewModel

            //var lancheslistViewModel = new LancheListViewModel();
            //lancheslistViewModel.Lanches = _lancheRepository.Lanches;
            //lancheslistViewModel.CategoriaAtual = "Categoria Atual";
            //return View(lancheslistViewModel);

            var lancheListViewModel = new LancheListViewModel
            {
                Lanches = lanches,
                CategoriaAtual = categoriaAtual
            };
            return View(lancheListViewModel);
        }
    }
}
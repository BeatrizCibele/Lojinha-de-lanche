using LanchesPage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanchesPage.ViewModels
{
    public class LancheListViewModel
    {
        //Definir uma propriedade do que se quer exibir
        //Quero exibir uma relação de lanches, uma lista de lanches

        public IEnumerable<Lanche> Lanches { get; set; }

        public string CategoriaAtual { get; set; }
    }
}

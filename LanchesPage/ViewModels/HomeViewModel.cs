using LanchesPage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanchesPage.ViewModels
{
    public class HomeViewModel
    {
        //Exibir aqui somente os lanches preferidos
        public IEnumerable<Lanche> LanchesPreferidos { get; set; }
    }
}

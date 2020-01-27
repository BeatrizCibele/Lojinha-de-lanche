using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LanchesPage.Models
{
    public class Lanche
    {
        public int LancheId { get; set; }
        
        [StringLength(100)]
        public string Nome { get; set; }
        [StringLength(100)]
        public string DescricaoCurta { get; set; }
        [StringLength(255)]
        public string DescricaoDetalhada { get; set; }
        public decimal Preco { get; set; }
        [StringLength(200)]
        public string ImagemURL { get; set; }
        public string ImagemThumbnailUrl { get; set; }
        public bool isLanchePreferido { get; set; }
        public bool EmEstoque { get; set; }
        public int CategoriaId { get; set; }
        public virtual Categoria Categoria{ get; set; }
    }
}

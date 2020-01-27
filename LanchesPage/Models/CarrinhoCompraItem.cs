using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LanchesPage.Models
{
    public class CarrinhoCompraItem
    {
        public int CarrinhoCompraItemId { get; set; }
        public Lanche Lanche { get; set; }
        public int Quantidade { get; set; }
        //Já que o item vai para o carrinho de compra deve-se expressar essa relação
        [StringLength(200)]
        public string CarrinhoCompraId { get; set; }
    }
}

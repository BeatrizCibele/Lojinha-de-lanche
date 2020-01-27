using Microsoft.EntityFrameworkCore.Migrations;

namespace LanchesPage.Migrations
{
    public partial class PopularTabelas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO CATEGORIAS(CategoriaNome, Descricao) VALUES ('Normal','Lanche feito com ingredientes normais')");
            migrationBuilder.Sql("INSERT INTO CATEGORIAS(CategoriaNome, Descricao) VALUES ('Natural','Lanche feito com ingredientes integrais e naturais')");


            migrationBuilder.Sql("INSERT INTO LANCHES(CategoriaId,DescricaoCurta,DescricaoDetalhada,EmEstoque,ImagemThumbnailUrl,ImagemURL,isLanchePreferido,Nome,Preco) VALUES(1,'Pão, hambúrguer, ovo, presunto, queijo e batata palha','Delicioso pão de hambúrguer com ovo frito;presuto e queijo de primeira qualidade acompahado com batata palha', 1,'http://www.macoratti.net/Imagens/lanches/cheesesalada1.jpg', 'http://www.macoratti.net/Imagens/lanches/cheesesalada1.jpg',0, 'Cheese Salada', 12.50)");
            migrationBuilder.Sql("INSERT INTO LANCHES(CategoriaId,DescricaoCurta,DescricaoDetalhada,EmEstoque,ImagemThumbnailUrl,ImagemURL,isLanchePreferido,Nome,Preco) VALUES(1,'Pão, presunto, mussarela e tomate','Delicioso pão francês quentinho na chapa com presunto e mussarela bem servidos com tomate preparado com carinho.', 1, 'http://www.macoratti.net/Imagens/lanches/mistoquente4.jpg','http://www.macoratti.net/Imagens/lanches/mistoquente4.jpg',0, 'Misto Quente', 8.00)");
            migrationBuilder.Sql("INSERT INTO LANCHES(CategoriaId,DescricaoCurta,DescricaoDetalhada,EmEstoque,ImagemThumbnailUrl,ImagemURL,isLanchePreferido,Nome,Preco) VALUES(1,'Pão, hambúrguer, presunto, mussarela e batata palha', 'Pão de hambúrguer especial com hambúrguer de nossa preparação e presunto e mussarela; acompanha a batata palha', 1, 'http://www.macoratti.net/Imagens/lanches/cheeseburger1.jpg','http://www.macoratti.net/Imagens/lanches/cheeseburger1.jpg',1, 'Cheese Burger', 11.00)");
            migrationBuilder.Sql("INSERT INTO LANCHES(CategoriaId,DescricaoCurta,DescricaoDetalhada,EmEstoque,ImagemThumbnailUrl,ImagemURL,isLanchePreferido,Nome,Preco) VALUES(2,'Pão Integral, queijo branco, peito de peru, cenoura, alface','Pão integral natural com queijo branco,peito de peru e cenoura ralada com alface picado e iogurte natural',1, 'http://www.macoratti.net/Imagens/lanches/lanchenatural.jpg', 'http://www.macoratti.net/Imagens/lanches/lanchenatural.jpg',0,'Peito Peru', 15.00)");
            migrationBuilder.Sql("INSERT INTO LANCHES(CategoriaId,DescricaoCurta,DescricaoDetalhada,EmEstoque,ImagemThumbnailUrl,ImagemURL,isLanchePreferido,Nome,Preco) VALUES(2,'Pão Integral, queijo branco, atum, cenoura, alface,iogurte', 'Pão integral natural com queijo branco, atum fresquinho com cenoura ralada e alface picado com cebola  e iogurte natural', 1, 'http://www.macoratti.net/Imagens/lanches/lanchenatural.jpg', 'http://www.macoratti.net/Imagens/lanches/lanchenatural.jpg',0, 'Atum', 14.00)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Delete from Categorias");
            migrationBuilder.Sql("Delete from Lanches");
        }
    }
}

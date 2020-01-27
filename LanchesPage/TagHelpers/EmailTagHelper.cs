using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanchesPage.TagHelpers
{
    //para poder utilizar a TagHelper é preciso configurá-la no arquivo viewImports
    //definindo a AddTagHelper e referenciando o caminho utilizado: nome da pasta e nome do projeto
    public class EmailTagHelper : TagHelper
    {
        public string Endereco { get; set; }
        public string Conteudo { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            //para poder utilizar um link como href
            output.TagName = "a";
            //configurar os atributos
            //definir os atributos, que serão 
            //vou montar um href com email, referenciando por endereco de email
            output.Attributes.SetAttribute("href", "mailto: " + Endereco);
            //definir o conteudo
            output.Content.SetContent(Conteudo);
        }
    }
}

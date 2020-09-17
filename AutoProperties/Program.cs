using Course;
using System;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("TV", 500.00, 10);

            p.Nome = "TV 4k"; // As propriedade com a utilização de GET e SET proporciona que a sintaxe para a atribuição para o tributo(Nome) seja mais simples de ser aplicada.
            p.Nome = "T"; //Nesse caso a propriedade irá barrar a alteração do nome do produto pois pela definição que colocamos no set apenas será alterado o nome se o mesmo possuir mais do que 1 caracter.

            Console.WriteLine(p.Nome);

            //p.Preco = 400.00; Nesse caso não será possível alterar o valor do preço pois na propriedade não foi utilizado o set para possiblitar a alteração do preço.
        }
    }
}

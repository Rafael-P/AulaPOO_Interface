using System;
using Interfaces.classes;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Carrinho carrinho = new Carrinho();

            Produto p1 = new Produto(121, "Play5", 10000f);
            Produto p2 = new Produto(122, "Xbox X", 5000f);
            Produto p3 = new Produto(123, "Nintendo Switch", 4000f);

            carrinho.Cadastrar(p1);
            carrinho.Cadastrar(p2);
            carrinho.Listar();

            Console.ForegroundColor = ConsoleColor.Red;
            
            carrinho.Alterar(p1.Codigo , p3);
            carrinho.Listar();
            
            Console.ResetColor();

        }//main
    }
}

using System;
using Tabuleiro;

namespace Xadrez_console
{
    internal class Program
    {
        static void Main(string[] args)
        {

            TabuleiroX tabuleiro = new TabuleiroX(8, 8);

            Tela.ImprimirTabuleiro(tabuleiro);

            Console.ReadLine();

        }
    }
}

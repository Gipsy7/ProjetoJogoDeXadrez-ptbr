﻿using System;
using Tabuleiro;

namespace Xadrez_console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Posicao P = new Posicao(3, 4);
            Console.WriteLine("Posição: " + P);

            TabuleiroX tabuleiro = new TabuleiroX(8, 8);
            Console.ReadLine();
        }
    }
}

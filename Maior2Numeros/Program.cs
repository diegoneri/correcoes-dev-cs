﻿using System;

namespace Maior2Numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            int primeiro, segundo, maiorNumero;

            Console.Write("Digite o primeiro número..: ");
            primeiro = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o segundo número...: ");
            segundo = Convert.ToInt32(Console.ReadLine());

            if (primeiro > segundo)
            {
                maiorNumero = primeiro;
            }
            else
            {
                maiorNumero = segundo;
            }

            Console.WriteLine($"O maior número é {maiorNumero}");
        }
    }
}

 using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharpp.EstruturaDeControle
{
    class EstruturaDoWhile
    {
        public static void Executar()
        {
            string entrada;

            do
            {
                Console.Write("Qual seu nome?");
                entrada = Console.ReadLine();

                Console.WriteLine("Seja Bem-vindo {0}", entrada);
                Console.WriteLine("Deseja continuar?(S/N)");
                entrada = Console.ReadLine();
            } while (entrada.ToLower() == "s");
        }
    }
}

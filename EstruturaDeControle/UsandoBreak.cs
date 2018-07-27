using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharpp.EstruturaDeControle
{
    class UsandoBreak
    {
        public static void Executar()
        {
            Random random = new Random();
            int numero = random.Next(1, 51);

            Console.WriteLine("O numero que queremos e {0}", numero);

            for (int i = 1; i <= 50; i++)
            {
                Console.Write("{0} e o numero que queremos? ", i);
                if (i == numero)
                {
                    Console.WriteLine("Sim!");
                    break;
                } else
                {
                    Console.WriteLine("Nao!");
                }
            }

            Console.WriteLine("Fim!");
        }
    }
}

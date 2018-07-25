using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharpp.Fundamentos
{
    class OperadoresAritmeticos
    {
        public static void Executar()
        {
            // Preço Desconto
            var preco = 1000.0;
            var imposto = 355;
            var desconto = 0.1;

            double total = preco + imposto;
            var totalComDesconto = total - total * desconto;
            Console.WriteLine("O preco final e {0}", totalComDesconto);

            //IMC
            double peso = 91.2;
            double altura = 1.82;
            double imc = peso / Math.Pow(altura, 2);
            Console.WriteLine($"IMC e {imc}.");

            //Numero Par/Impar
            int par = 24;
            int impar = 55;
            Console.WriteLine("{0}/2 tem resto {1}", par,par % 2);
            Console.WriteLine("{0}/2 tem resto {1}", impar,impar % 2);

        }
    }
}

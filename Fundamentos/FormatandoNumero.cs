using System;
using System.Globalization;

namespace CursoCSharpp.Fundamentos
{
    class FormatandoNumero
    {
        public static void Executar()
        {
            double valor = 15.175;
            Console.WriteLine(valor.ToString("F1"));     //F1 uma casa decimal
            Console.WriteLine(valor.ToString("C"));     //C valor monetário
            Console.WriteLine(valor.ToString("P"));     // P valor percentual 
            Console.WriteLine(valor.ToString("#.##"));  // formatacao mais expecifica


            CultureInfo cultura = new CultureInfo("en-US");
            Console.WriteLine(valor.ToString("C3", cultura));

            int inteiro = 256;
            Console.WriteLine(inteiro.ToString("D10")); //preencher zeros a esquerda ate completa 10 casas decimais 

        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharpp.Fundamentos
{
    class VariaveisEConstantes
    {
        public static void Executar()
        {
            // area de circunferencia
            Double raio = 4.5;
            const double PI = 3.14;

            raio = 5.5;
            //PI = 3.1415;

            double area = PI * raio * raio;
            Console.WriteLine(area);
            Console.WriteLine("Area e " + area);

            //tipos internos

            bool estaChovendo = true;
            Console.WriteLine("Esta chovendo " + estaChovendo);

            byte idade = 45;
            Console.WriteLine("Idade " + idade);

            sbyte saldoDeGols = sbyte.MinValue;
            Console.WriteLine("Saldos de Gols " + saldoDeGols);

            short salario = short.MaxValue;
            Console.WriteLine("Salario " + salario);

            int menorValorInt = int.MinValue;    // Mais usados dos inteiros!
            Console.WriteLine("Menor valor int " + menorValorInt);

            uint populacaoBrasileira = 207_600_00;
            Console.WriteLine("Populacao Brasileira " + populacaoBrasileira);

            long menorValorLong = long.MinValue;
            Console.WriteLine("Menor long " + menorValorLong);

            ulong populacaoMundial = 7_600_000_000;
            Console.WriteLine("Populacao mundial " + populacaoMundial);

            float precoComputador = 1299.99F;
            Console.WriteLine("Preco do Computador " + precoComputador);


            double valorDeMercadoDaApple = 1_000_000_000.00;   // Mais usados dos reais!
            Console.WriteLine("Valor de mercado da Apple " + valorDeMercadoDaApple);

            decimal distanciaEntreEstrelas = decimal.MaxValue;
            Console.WriteLine("Distancia entre Estrelas " + distanciaEntreEstrelas);

            char letra = 'b';
            Console.WriteLine("Letra " + letra);

            string texto = "Seja bem vindo ao curso de C#!";
            Console.WriteLine(texto);
        }
    }
}

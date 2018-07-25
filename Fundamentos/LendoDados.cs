using System;
using System.Globalization;
namespace CursoCSharpp.Fundamentos
{
    class LendoDados
    {
        public static void Executar()
        {
            Console.Write("Qual e seu nome? ");
            string nome = Console.ReadLine();

            Console.Write("Qual e sua idade? ");
            int idade = int.Parse(Console.ReadLine());  //convertendo a string pra int com int.Parse

            Console.Write("Qual e seu salario? ");
            double salario = double.Parse(Console.ReadLine(),
                CultureInfo.InvariantCulture);
            
            Console.WriteLine($"{nome} {idade} R${salario}");  //interpolacao
        }
    }
}

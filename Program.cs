using System;
using System.Collections.Generic;


using CursoCSharpp.Fundamentos;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentarios - Fundamentos", Comentarios.Executar },
                {"Variaveis e Constantes - Fundamentos", VariaveisEConstantes.Executar },
                {"Inferencia - Fundamentos", Inferencia.Executar },
                {"Interpolacao - Fundamentos", interpolacao.Executar },
                {"Notacao Ponto - Fundamentos", NotacaoPonto.Executar },
                {"Lendo Dados - Fundamentos", LendoDados.Executar },
                {"Formatando Numero - Fundamentos", FormatandoNumero.Executar },
                {"Conversoes - Fundamentos", Conversoes.Executar },
                {"Operadores Aritmeticos - Fundamentos", OperadoresAritmeticos.Executar },
                {"Operadores Relacionais - Fundamentos", OperadoresRelacionais.Executar },
                {"Operadores Logicos - Fundamentos", OperadoresLogicos.Executar },
                {"Operadores Atribucao - Fundamentos", OperadoresAtribucao.Executar },
                {"Operadores Unarios - Fundamentos", OperadoresUnarios.Executar },
                {"Operador Ternario - Fundamentos", OperadorTernario.Executar },
            });

            central.SelecionarEExecutar();
        }
    }
}
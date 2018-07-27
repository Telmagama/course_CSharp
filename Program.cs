using System;
using System.Collections.Generic;


using CursoCSharpp.Fundamentos;
using CursoCSharpp.EstruturaDeControle;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                //Fundamentos
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

                //Estruturas de Controle
                {"Estrutura If - Estrutura de Controle", EstruturaIf.Executar },
                {"Estrutura If Else - Estrutura de Controle", EstruturaIfElse.Executar },
                {"Estrutura If Else If - Estrutura de Controle", EstruturaIfElseIf.Executar },
                {"Estrutura Switch - Estrutura de Controle", EstruturaSwitch.Executar },
                {"Estrutura While - Estrutura de Controle", EstruturaWhile.Executar },
                {"Estrutura DO While - Estrutura de Controle", EstruturaDoWhile.Executar },
                {"Estrutura For - Estrutura de Controle", EstruturaFor.Executar },
                {"Estrutura Foreach - Estrutura de Controle", EstruturaForEach.Executar },
                {"Usando Break - Estrutura de Controle", UsandoBreak.Executar },
                {"Usando Continue - Estrutura de Controle", UsandoContinue.Executar },
            });

            central.SelecionarEExecutar();
        }
    }
}
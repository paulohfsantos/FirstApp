using System;
using System.Collections.Generic;
using FirstApp.Fundamentals;
using FirstApp.ClassNMethods;

namespace CursoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                //{"Membros - Classes e metodos", Membros.Executar},
                //{"Membros - Classes e metodos", Construtores.Executar},
                {"VarNConsts - Fundamentals", VarNConsts.Executar},
                {"Interpolation - Fundamentals", Interpolation.Executar},
                {"Notação Ponto - Fundamentals", DotNotation.Executar},
                {"Lendo Dados - Fundamentals", ReadingData.Executar},
                {"Num Format - Fundamentals", NumberFormat.Executar},
                {"Conversões - Fundamentals", Conversions.Executar},
                {"Operadores aritméticos- Fundamentals", Operators.Executar},
                {"Operadores relacionais - Fundamentals", RelOperators.Executar},
                {"Operadores Lógicos - Fundamentals", LogicalOperators.Executar},
                {"Operadores de Atribuição - Fundamentals", AssignmentOperators.Executar},
                {"Operadores unários - Fundamentals", UnaryOperators.Executar},
                {"Operador Ternário - Fundamentals", TernaryOperator.Executar},
                // control structure

                //{"Pessoas - Classes e metodos", Pessoas},
            });

            central.SelecionarEExecutar();
        }
    }
}

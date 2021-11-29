using System;
using System.Collections.Generic;
using FirstApp.Fundamentos;
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
                {"VarNConsts - Fundamentos", VarNConsts.Executar},
                {"Interpolation - Fundamentos", Interpolation.Executar},
                {"Notação Ponto - Fundamentos", DotNotation.Executar},
                {"Lendo Dados - Fundamentos", ReadingData.Executar},
                {"Num Format - Fundamentos", NumberFormat.Executar},
                {"Conversões - Fundamentos", Conversions.Executar},
                {"Operadores aritméticos- Fundamentos", Operators.Executar},
                {"Operadores relacionais- Fundamentos", RelOperators.Executar},
                //{"Pessoas - Classes e metodos", Pessoas},
            });

            central.SelecionarEExecutar();
        }
    }
}

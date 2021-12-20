using System;
using System.Collections.Generic;
using System.Text;

namespace FirstApp.Fundamentals
{
    class AssignmentOperators
    {
        public static void Executar()
        {
            int num1 = 3;
            num1 += 10; // num1 = num1 + 10 = 13
            num1 -= 3; // num1 = num1 - 3 = 10

            Console.WriteLine(num1);

            dynamic c = new System.Dynamic.ExpandoObject();
            c.nome = "joao";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace FirstApp.Fundamentals
{
    class TernaryOperator
    {
        public static void Executar()
        {
            double nota = 5.0;
            string result = nota >= 7.0 ? "Approved" : "Not Approved";

            Console.WriteLine(result);
        }
    }
}

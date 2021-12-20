using System;
using System.Collections.Generic;
using System.Text;

namespace FirstApp.Fundamentals
{
    class UnaryOperators
    {
        public static void Executar()
        {
            var negativeValue = -5;
            var num1 = 2;
            var boolean = true;

            Console.WriteLine(-negativeValue);
            Console.WriteLine(!boolean);

            num1++;
            Console.WriteLine(num1);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace FirstApp.Fundamentos
{
    class Operators
    {
        public static void Executar()
        {
            // discount price
            var price = 1000.0;
            var taxation = 355;
            var discount = 0.1;

            double totalValue = price + taxation; // 1355.0
            var discountTotal = totalValue - (totalValue * discount); // 1355 - 1355 * 0.1
            Console.WriteLine("final price is: {0}", discountTotal); // output: 1219.5


            // IMC
            double weight = 91.2;
            double height = 1.82;
            double imc = weight / Math.Pow(height, 2); // height²
            Console.WriteLine($"IMC is: {imc}.");


            // even odd number
            int even = 24;
            int odd = 55;

            Console.WriteLine("{0}/2 has rest {1}", even, even % 2);
            Console.WriteLine("{0}/2 has rest {1}", odd, odd % 2);
        }
    }
}

using System;

namespace FirstApp.Fundamentals
{
    class NumberFormat
    {
        public static void Executar()
        {
            double val = 15.175;

            // arredondamento
            Console.WriteLine(val.ToString("F1"));
            // $
            Console.WriteLine(val.ToString("C"));
            // %
            Console.WriteLine(val.ToString("P"));
        }
    }
}

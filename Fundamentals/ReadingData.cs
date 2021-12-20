using System;
using System.Globalization;

namespace FirstApp.Fundamentals
{
    class ReadingData
    {
        public static void Executar()
        {
            Console.Write("Whats your name? ");
            string name = Console.ReadLine();

            Console.Write("Whats your age? ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Whats your wage? ");
            double wage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            Console.WriteLine($"nome: {name}, age: {age}, wage: ${wage}");
        }
    }
}

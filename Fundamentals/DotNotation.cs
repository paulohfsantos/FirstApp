using System;
using System.Collections.Generic;
using System.Text;

namespace FirstApp.Fundamentals
{
    class DotNotation
    {
        public static void Executar()
        {
            string greetings = "hello";
            var NewGreetings = greetings
                .Insert(5, "World!")
                .Replace("hello", "Hello ");

            Console.WriteLine(NewGreetings);

            string nullVal = "null";

            if (nullVal == null)
            {
                Console.WriteLine("This variable is actually null");
            } else
            {
                Console.WriteLine($"value: {nullVal}, length: {nullVal?.Length}");
            }
        }
    }
}

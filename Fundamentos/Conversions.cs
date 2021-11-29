using System;

namespace FirstApp.Fundamentos
{
    class Conversions
    {
        public static void Executar()
        {
            int inteiro = 10;
            double quebrado = inteiro; // no information loss
            Console.WriteLine(quebrado);

            double nota = 9.5;
            int notaTruncada = (int) nota;

            Console.WriteLine(notaTruncada);

            // ----

            Console.Write("Type your age: ");
            
            string stringAge = Console.ReadLine();

            int integerAge;

            if (!int.TryParse(stringAge, out integerAge))
            {
                Console.WriteLine("Value is not a number");
            }

            Console.WriteLine("Computed Age: {0}", integerAge);

        }
    }
}

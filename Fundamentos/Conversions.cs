using System;

namespace FirstApp.Fundamentos
{
    class Conversions
    {
        public static void Executar()
        {
            int inteiro = 10;
            // converting an int to double without any explict conversion method
            double quebrado = inteiro; // no information loss
            Console.WriteLine(quebrado);

            double nota = 9.5;
            // int notaTruncada = nota (error)
            
            // right way to convert from double to int properly with information loss (cast)
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

            // using System.Convert
            //integerAge = Convert.ToInt32(stringAge);
            //Console.WriteLine("Result: {0}", integerAge);

        }
    }
}

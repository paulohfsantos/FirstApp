using System;

namespace FirstApp.Fundamentos
{
    class VarNConsts
    {
        public static void Executar()
        {
            // circunferencia
            double radius = 4.5;
            const double PI = 3.14;

            double area = PI * radius * radius;

            Console.WriteLine($"area is {area}");

            bool isRaining = true;

            if (isRaining)
            {
                Console.WriteLine("Is actually raining!");
            } else
            {
                Console.WriteLine("Is not raining, bruh..");
            }
        }
    }
}

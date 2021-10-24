using System;
using System.Collections.Generic;
using System.Text;

namespace FirstApp.ClassNMethods
{
    class Membros
    {
        public static void Executar()
        {
            //Pessoas person = new Pessoas();
            //person.age = 25;
            //person.name = "Paulo";

            Pessoas person = new Pessoas
            {
                age = 25,
                name = "Paulo"
            };

            //Console.WriteLine($"{person.name} has {person.age} years");

            person.ApresentarConsole();
        }
    }
}

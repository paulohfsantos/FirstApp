using System;
using System.Collections.Generic;
using System.Text;

namespace FirstApp.ClassNMethods
{
    class Pessoas
    {
        public string name;
        public int age;

        public string Apresentar()
        {
            return String.Format($"Hey, i'm {name} and I have {age}");
        }

        public void ApresentarConsole()
        {
            Console.WriteLine(Apresentar());
        }
    }
}

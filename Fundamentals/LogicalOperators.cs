using System;
using System.Collections.Generic;
using System.Text;

namespace FirstApp.Fundamentals
{
    class LogicalOperators
    {
        public static void Executar()
        {
            bool jobOneDone = true;
            bool jobTwoDone = false;

            bool Bought50InchTv = jobOneDone && jobTwoDone;
            Console.WriteLine("Did he bought the 50 inch TV? {0}", Bought50InchTv);

            bool boughtIceCream = jobOneDone || jobTwoDone;
            Console.WriteLine("Did he bought the ice cream? {0}", boughtIceCream);
            Console.WriteLine("Healthy? {0}", !boughtIceCream);

            bool Bought32InchTv = jobOneDone ^ jobTwoDone;
            Console.WriteLine("Did he bought the 32 inch TV? {0}", Bought32InchTv);
        }
    }
}

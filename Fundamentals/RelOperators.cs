using System;

namespace FirstApp.Fundamentals
{
    class RelOperators
    {
        public static void Executar()
        {
            Console.Write("Type your note: ");
            double.TryParse(Console.ReadLine(), out double note);
            double halfNote = 7.0;

            Console.WriteLine("invalid note? {0}", note > 10.0);
            Console.WriteLine("invalid note? {0}", note < 0.0);
            Console.WriteLine("perfect? {0}", note == 0.0);
            Console.WriteLine("is it possible to get better? {0}", note != 10.0);
            Console.WriteLine("approved by half note? {0}", note >= halfNote);
            Console.WriteLine("recovery? {0}", note < halfNote);
            Console.WriteLine("Failed? {0}", note <= 3.0);
        }
    }
}

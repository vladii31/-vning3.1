
using System;

namespace uppgift3._1
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Hur gammal är du ?(år)");
            int ålder = int.Parse(Console.ReadLine());
            if (ålder > 15 && ålder < 20)
            {
                Console.WriteLine("Du får delta i tävlingen,");
            }
            else if (ålder >20 && ålder < 100)
            {
                Console.WriteLine("Du får INTE delta i tävlingen");
            }

        }
    }
}

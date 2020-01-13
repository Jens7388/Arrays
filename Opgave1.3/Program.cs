using System;

namespace Opgave1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Jens", "Mathias", "Christian", "Marc", "Semko", "Nikolaj", "Oliver" };
            Console.WriteLine("Klassens elever hedder:");
            for(int i = 0; i < names.Length; i++)
            {
                Console.WriteLine($"{names[i]}");
            }
            Console.ReadLine();
        }
    }
}

using System;

namespace Opgave2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[5];
            Console.WriteLine("Indtast 5 drengenavne:");
            for(int i = 0; i < names.Length; i++)
            {
                names[i] = Console.ReadLine();
            }
            Console.WriteLine("\nDu har indtastet følgende navne:");
            for(int i = 0; i < names.Length; i++)
            {
                Console.WriteLine($"{names[i]}");
            }
            Console.ReadLine();

        }
    }
}

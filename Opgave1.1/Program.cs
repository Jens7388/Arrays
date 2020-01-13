using System;

namespace Opgave1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] byer = { "København", "Aarhus", "Odense", "Aalborg", "Randers" };

            for(int i = 0; i < byer.Length; i++)
            {
                if(i == 0)
                {
                    Console.WriteLine($"Danmarks største by er: {byer[i]}");
                }
                else
                {
                    Console.WriteLine($"Danmarks {i + 1}. største by er: {byer[i]}");
                }
            }
            Console.ReadLine();
        }
    }
}

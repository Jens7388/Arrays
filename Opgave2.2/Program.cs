using System;

namespace Opgave2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool[] parkingSpaces = new bool[10];
            Console.WriteLine("Skriv om 10 parkeringspladser er ledige, hvis de er, skriv true, hvis ikke, skriv false");
            int availableSpaces = 0;
            for(int i = 0; i < parkingSpaces.Length; i++)
            {
                Console.WriteLine($"Parkeringsplads {i + 1}: ");
                string input = Console.ReadLine();
                if(input == "true")
                {
                    parkingSpaces[i] = true;
                }
                else
                {
                    parkingSpaces[i] = false;
                }
                if(parkingSpaces[i] == true)
                {
                    availableSpaces++;
                }
            }
            Console.WriteLine($"Der er {availableSpaces} ledige parkeringspladser");
            Console.ReadLine();
        }
    }
}

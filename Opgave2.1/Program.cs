using System;

namespace Opgave2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                string[] heightInputs = new string[10];
                Console.WriteLine("Indtast 10 personers højde i cm, og se deres gennemsnitshøjde:");
                int sum = 0;
                for(int i = 0; i < heightInputs.Length; i++)
                {
                    heightInputs[i] = Console.ReadLine();
                    int.TryParse(heightInputs[i], out int heights);
                    sum += heights;
                }
                int averageHeight = sum / 10;
                Console.WriteLine($"Personernes gennemsnitshøjde er: {averageHeight} cm");
                Console.ReadLine();
            }
        }
    }
}

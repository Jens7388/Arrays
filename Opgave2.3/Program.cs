using System;

namespace Opgave2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numberInputs = new double[5];
            Console.WriteLine("Indtast 5 tal med to decimaler, de vil derefter blive vist i modsatte rækkefølge");
            for(int i = 0; i < numberInputs.Length; i++)
            {
                numberInputs[i] = double.Parse(Console.ReadLine());
            }
            Console.WriteLine("Du har indtastet følgende tal:");
            for(int i = numberInputs.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(numberInputs[i]);
            }
            Console.ReadLine();
        }
    }
}

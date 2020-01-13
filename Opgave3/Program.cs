using System;

namespace Opgave3
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("Skriv hvor mange priser du vil indtaste (min 1, max 25.)");
                string input = Console.ReadLine();
                int.TryParse(input, out int i);
                double[] prices = new double[i];
                double sum = 0;
                if(i > 0 && i <= 25)
                {
                    Console.WriteLine($"Skriv {i} priser: (priserne skal være over 0,00 og maks 20000)");
                    for(i = 0; i < prices.Length; i++)
                    {
                        string priceInput = Console.ReadLine();
                        double.TryParse(priceInput, out prices[i]);
                        //hvis prisen ikke er tilladt får man mulighed for at skrive en ny med det samme.
                        if(prices[i] < 0.01 || prices[i] > 20000)
                        {
                            Console.WriteLine("Ugyldig pris! skriv en ny:");
                            i--;
                        }
                        else
                        {
                            sum += prices[i];
                        }
                    }
                    Console.WriteLine($"Samlet pris uden moms: {sum * 0.75}");
                    Console.WriteLine($"Gennemsnitspris: {sum / prices.Length}");
                    Console.WriteLine($"Samlet moms: {sum * 0.25}");
                    Console.WriteLine($"Samlet pris inklusiv moms: {sum}");
                    Console.ReadLine();
                    Console.Clear();
                }              
                else
                {
                    Console.WriteLine("Ugyldigt antal! prøv igen");
                    Console.ReadLine();
                }
            }
        }
    }
}

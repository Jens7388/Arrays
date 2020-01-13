using System;

namespace Opgave1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[7];
            numbers[0] = -50;
            numbers[1] = -30;
            numbers[2] = -10;
            numbers[3] =  0;
            numbers[4] =  10;
            numbers[5] =  30;
            numbers[6] =  50;

            for(int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"Tal {i + 1}: {numbers[i]}");          
            }
            Console.ReadLine();
        }
    }
}

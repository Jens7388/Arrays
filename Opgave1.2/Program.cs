using System;

namespace Opgave1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] months = { "Januar", "Februar", "Marts", "April", "Maj", "Juni", "Juli", "August", "September", "Oktober", "November", "December" };
            double[] monthlyAverage = new double[12];
            monthlyAverage[0] = 0.0;
            monthlyAverage[1] = 0.0;
            monthlyAverage[2] = 2.1;
            monthlyAverage[3] = 5.7;
            monthlyAverage[4] = 10.8;
            monthlyAverage[5] = 14.3;
            monthlyAverage[6] = 15.6;
            monthlyAverage[7] = 15.7;
            monthlyAverage[8] = 12.7;
            monthlyAverage[9] = 9.1;
            monthlyAverage[10] = 4.7;
            monthlyAverage[11] = 1.6;

            double sum = 0;
            for(int i = 0; i < months.Length; i++)
            {
                Console.WriteLine($"Gemmensnitstemperaturen i {months[i]} fra 1961-1990 var {monthlyAverage[i]} grader");
                sum += monthlyAverage[i];
            }
            double yearlyAverage = sum / 12;
            Console.WriteLine($"\nDen årlige gemmensnitstemperatur fra 1961-1990 var {yearlyAverage:f} grader");
            Console.ReadLine();
        }
    }
}

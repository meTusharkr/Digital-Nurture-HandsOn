using System;

namespace FinancialForecasting
{
    class Program
    {
        // Recursive method to calculate future value
        static double PredictFutureValue(double currentValue, double growthRate, int years)
        {
            if (years == 0)
            {
                return currentValue;
            }

            return PredictFutureValue(currentValue * (1 + growthRate), growthRate, years - 1);
        }

        static void Main(string[] args)
        {
            Console.Write("Enter Current Value: ");
            double currentValue = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Annual Growth Rate (in %): ");
            double growthRate = Convert.ToDouble(Console.ReadLine()) / 100;

            Console.Write("Enter Number of Years: ");
            int years = Convert.ToInt32(Console.ReadLine());

            double futureValue = PredictFutureValue(currentValue, growthRate, years);

            Console.WriteLine();
            Console.WriteLine("Predicted Future Value: " + futureValue.ToString("F2"));
        }
    }
}

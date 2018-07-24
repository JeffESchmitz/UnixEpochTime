using System;

namespace ConsoleApp1
{
    class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(":: ConvertFromEpochToDateTime - with double ::");
            Console.WriteLine();

            const double testEpoch1 = 1530787490958.74;
            ConvertFromEpochToDateTime(testEpoch1);
            Console.WriteLine();

            const double testEpoch2 = 1530787490958.7;
            ConvertFromEpochToDateTime(testEpoch2);
            Console.WriteLine();


            Console.ReadKey();
        }

        private static void ConvertFromEpochToDateTime(double epochValue)
        {
            var unixStartDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            var resultDateTime = unixStartDateTime.AddMilliseconds(epochValue).ToLocalTime();
            Console.WriteLine(resultDateTime.ToString("O"));
            Console.WriteLine($"Ticks: {resultDateTime.Ticks}");
        }
    }
}

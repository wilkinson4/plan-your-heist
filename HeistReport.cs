using System;

namespace PlanYourHeist
{
    public class HeistReport
    {
        public HeistReport()
        {
            SuccessCount = 0;
            FailureCount = 0;
        }
        public int SuccessCount { get; set; }
        public int FailureCount { get; set; }

        public void Print()
        {
            Console.WriteLine();
            Console.WriteLine("-------");
            Console.WriteLine("REPORT");
            Console.WriteLine("-------");
            Console.WriteLine($"Successes: {SuccessCount}");
            Console.WriteLine($"Failures: {FailureCount}");
        }
    }
}
using System;
namespace UCEmpWage
{
    class Program
    {
        static void Main(string[] args)
        {
            int IS_FULL_TIME = 1;
            int EMP_RATE_PER_HOUR = 20;
            int emphrs = 0;
            int empWage = 0;
            Random random = new Random();
            int empcheck = random.Next(0, 2);
            if (empcheck == IS_FULL_TIME)
            {
                emphrs = 8;
            }
            else
            {
                emphrs = 0;

            }
            empWage = emphrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("emp wage : " + empWage);
        }
    }
}
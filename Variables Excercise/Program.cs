using System;

namespace Variables_Excercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World.");
            string name = "James";
            int age = 36;
            char lastInital = 'G';
            bool maratial_Status = false;
            double workHours = 46.5;
            decimal hourlyPay = 8.55m;

            Console.WriteLine($"My name is {name} {lastInital}. Am I married? {maratial_Status}. I work for  {workHours} hours a week at {hourlyPay} dollars an hour.");


        }
    }
}

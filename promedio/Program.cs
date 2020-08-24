using System;

namespace promedio
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            int sum = 0;
            int div = 0;
            bool granted;

            do
            {
                granted = int.TryParse(Console.ReadLine(), out number);

                if (granted)
                {
                     sum += number;
                     div++;

                }
            } while (granted != false);

            Console.WriteLine(sum/div);
        }
    }
}

using System;

namespace sumatoria
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            int sum = 0;
            bool granted;

            do
            {
                granted = int.TryParse(Console.ReadLine(), out number);

                if (granted)
                    sum += number; 
                
            } while (granted != false);

            Console.WriteLine(sum);
        }
    }
}

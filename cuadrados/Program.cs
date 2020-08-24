using System;

namespace cuadrados
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            int vow = 0;
            bool granted;

            do
            {
                granted = int.TryParse(Console.ReadLine(), out number);

                if (granted)
                {
                     vow = number * number;
                     Console.WriteLine(vow);
                }
                    
                
               
            } while (granted != false);
        }
    }
}

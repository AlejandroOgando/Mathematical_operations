using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maximo
{
    class Program
    {
        static void Main(string[] args)
        {
             int num;
            bool granted;
            List<int> numbers = new List<int>();
           
            do
            {
                granted = int.TryParse(Console.ReadLine(), out num);

                if (granted)
                {
                        numbers.Add(num);
                }
            } while (granted != false);

           Console.WriteLine(numbers.Max());
        }
    }
}

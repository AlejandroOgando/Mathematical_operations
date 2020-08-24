using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace filtro_pares
{
    class Program
    {
       
        static void Main(string[] args)
        {
            int number;
            bool granted;
            List<int> pairs = new List<int>();
           
            do
            {
                granted = int.TryParse(Console.ReadLine(), out number);

                if (granted)
                {
                    if ((number % 2) == 0)
                    {
                        pairs.Add(number);

                    }
                }
            } while (granted != false);

           foreach (int num in pairs)
           {
               Console.WriteLine(num);
               
           }
        }
    }
}

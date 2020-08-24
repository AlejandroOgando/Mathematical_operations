using System;

namespace contador
{
    class Program
    {
        static void Main(string[] args)
        {
           int number;

           if (int.TryParse(args[0], out number) && number > 0)
           {
               for (int i = 1; i <= number; i++)
               {
                   Console.WriteLine(i);
               }
           }
        }
    }
}

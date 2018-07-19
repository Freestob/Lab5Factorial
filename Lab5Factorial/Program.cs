using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a number.");
            int userNumber = int.Parse(Console.ReadLine());
            int x = userNumber;
            for (int i = 1; i < x; i++)
            {
                int factorial = userNumber * --userNumber;
                Console.WriteLine(factorial);
                Console.ReadKey();
            }
            

        }

    }
}

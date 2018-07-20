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
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Please input a number.");
                int userNumber = int.Parse(Console.ReadLine());

                long result;

                result = userNumber;
                for (int num = 1; num < userNumber; num++)
                {
                    result = result * num;
                }
                Console.WriteLine(result);
                Console.ReadKey();

                Console.WriteLine("Do you want to run again (Y/N)? ");


                if (Console.ReadLine().ToLower() != "y")
                {
                    Console.WriteLine("Goodbye");
                    Console.ReadLine();
                    break;

                }
            }
        }
    }
}

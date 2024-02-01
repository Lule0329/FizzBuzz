using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            int n = 100;

            for (i = 1; i <= n; i++) 
            { 
                if (i % 3 == 0 && i % 15 == 0)
                {
                    Console.WriteLine("Fizz Buzz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 3 != 0 && i % 5 != 0 && i % 15 != 0)
                {
                    Console.WriteLine("Uneven " + i);
                }
            }
        }
    }
}

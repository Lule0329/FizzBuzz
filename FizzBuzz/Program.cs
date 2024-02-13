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
                if (i % 3 == 0 && i % 15 == 0) // Skriver Fizz Buzz om talet är delbart med 3 och 15
                {
                    Console.WriteLine("Fizz Buzz");
                }
                else if (i % 5 == 0) // Skriver Buzz om talet är delart med 5
                {
                    Console.WriteLine("Buzz");
                }
                else if (i % 3 == 0) // Skriver Fizz om talet är delbart med 3
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 3 != 0 && i % 5 != 0 && i % 15 != 0) // Skriver Uneven + talet om talet inte är delbart med 3, 5 eller 15
                {
                    Console.WriteLine("Uneven " + i);
                }
            }
        }
    }
}

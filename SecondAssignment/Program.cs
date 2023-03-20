using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 0;

            Console.WriteLine("Please enter 10 numbers:");
            for (int i = 0; i < 10; i++)
            {
                int input = Convert.ToInt32(Console.ReadLine());
                x += input;
            }

            int average = x / 10;
            Console.WriteLine($"The sum of the numbers is {x}");
            Console.WriteLine($"The average of the numbers is {average}");
        }
    }
}


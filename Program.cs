using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 0, number2 = 0, end ;
            for (int i = 1; i <= 10; i++) 
            {
                number2 += i;
                number1 += i * i;

            }
            number2 = number2 * number2;
            end = number2 - number1;
            Console.WriteLine(end);
        }
    }
}

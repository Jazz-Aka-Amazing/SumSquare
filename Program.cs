﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int square1 = 0, square2 = 0, end ;
            for (int i = 1; i <= 10; i++) 
            {
                square2 += i;
                square1 += i * i;

            }
            square2 = square2 * square2;
            end = square2 - square1;
            Console.WriteLine(end);
        }
    }
}

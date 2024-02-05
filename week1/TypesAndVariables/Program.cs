﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World");

            //Value Types
            int number1 = -2147483648;
            int number2 = 2147483647;
            Console.WriteLine("Number 1 is {0}", number1);
            Console.WriteLine("Number 2 is {0}", number2);

            long number3 = -9223372036854775808;
            long number4 = 9223372036854775807;
            Console.WriteLine("Number 3 is {0}", number3);
            Console.WriteLine("Number 4 is {0}", number4);

            short number5 = -32768;
            short number6 = 32767;
            Console.WriteLine("Number 5 is {0}", number5);
            Console.WriteLine("Number 6 is {0}", number6);

            byte number7 = 0;
            byte number8 = 255;
            Console.WriteLine("Number 7 is {0}", number7);
            Console.WriteLine("Number 8 is {0}", number8);

            bool condition = true;
            bool condition2 = false;

            char character = 'A';
            char character2 = '4';
            Console.WriteLine("Character is : {0}", (int)character);
            Console.WriteLine("Character 2 is : {0}", (int)character2);

            double number9 = 10.4;
            Console.WriteLine("Number 9 is {0}", number9);

            decimal number10 = 23.12m;
            Console.WriteLine("Number 10 is {0}", number10);

            Console.WriteLine((int)Days.Friday);







            Console.ReadLine();
        }
    }

    enum Days
    {
        Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
    }
}
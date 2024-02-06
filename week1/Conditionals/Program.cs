using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = 9;
            if (number==10)
            {
                Console.WriteLine("Number is 10");
            }
            else if(number==20)
            {
                Console.WriteLine("Number is 20");

            }
            else 
            {
                Console.WriteLine("Number isn't 10");

            }

            var number2 = 21;
            Console.WriteLine(number2 == 10 ? "Number is 10" : "Number isn't 10");

            var number3 = 17;
            switch (number)
            {
                case 10:
                    Console.WriteLine("Number is 10");
                    break;
                case 20:
                    Console.Write("Number is 20");
                    break;
                default:
                    Console.WriteLine("Number isn't 10");
                    break;
            }






            Console.ReadLine();

        }
    }
}
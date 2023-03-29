using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a Program to Check Whether Number is Even orOdd

namespace OddorEven
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int num1;
         


            Console.WriteLine("Please enter your number");
            num1 = int.Parse(Console.ReadLine());

            if (num1 % 2 == 0)
            {

                Console.WriteLine("Your number is even : {0}", num1);

            }
            else
            {

                Console.WriteLine("Your number is odd : {0}", num1);
            }

            Console.ReadLine();
        }
    }
}

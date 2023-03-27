using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Write a program where the user is asked to enter two
integers (divisor and dividend) and the quotient and the
remainder of their division is computed.(Both divisor and
dividend should be integers.)

 */


namespace Number4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int divisor, dividend, quotient, remainder;

            Console.WriteLine("Following is the program to find divisor, divident, quotient, remainder");

            Console.WriteLine("\n");

            Console.Write("Please enter your number: ");
            dividend = int.Parse(Console.ReadLine());

            Console.Write("Please enter your number: ");
            divisor = int.Parse(Console.ReadLine());


            quotient = dividend / divisor;

            remainder = dividend % divisor;

            Console.WriteLine("\n");

            Console.WriteLine("Following is your Quotient: {0}", quotient);
            Console.WriteLine("\n");


            Console.WriteLine("Following is your Remainder: {0}", remainder);

            Console.ReadLine();

        }
    }
}

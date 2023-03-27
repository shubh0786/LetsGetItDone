using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//3) Write a Program to Add Two Integer Numbers Entered by User

namespace Number_3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Following is the program to add two number entered by the user Please enter your number");


            Console.WriteLine("\n");

            Console.Write("Please enter your number: ");
            int num1= int.Parse(Console.ReadLine());

            Console.WriteLine("\n");

            Console.Write("Please enter your Second number: ");
            int num2= int.Parse(Console.ReadLine());

            Console.WriteLine("\n");

            int num3 = num1 + num2;

            Console.WriteLine("\n");

            Console.WriteLine("Following are your two numbers: {0} + {1}",num1,num2);

            Console.WriteLine("\n");

            Console.ReadLine();

            Console.WriteLine("This is the sum of your numbers {0}", num3);

            Console.ReadLine();

        }
    }
}

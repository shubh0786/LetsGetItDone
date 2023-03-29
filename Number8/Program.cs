using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Write a Program to Multiply two decimal Numbersentered by User
namespace Number8
{
    internal class Program
    {
        static void Main(string[] args)
        {

            decimal num1;
            decimal num2;

            decimal num3;
           
           

            Console.WriteLine("Please enter your number");
            num1= decimal.Parse(Console.ReadLine());

            Console.WriteLine("Please enter your second number");
            num2= decimal.Parse(Console.ReadLine());


            num3 = num1 * num2;

            Console.WriteLine("Following are the results: {0} x {1} = {2} ", num1, num2, num3);
            Console.ReadLine(); 

        }
    }
}

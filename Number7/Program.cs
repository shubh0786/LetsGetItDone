using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//7) Write a Program to Find ASCII Value of a Character


namespace Number7
{
    internal class Program
    {
        static void Main(string[] args)
        {

            char ch;

            Console.Write("Please enter you character: \n");

            ch = char.Parse(Console.ReadLine());

            int asII = (int)ch;


            Console.WriteLine("The ASCII value of {0} is {1}",ch, asII);
            Console.ReadLine();

        }
    }
}

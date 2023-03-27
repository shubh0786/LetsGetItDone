using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a Program to Print Integer Number Entered by User

namespace Number_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Write Your Number");


            int num = int.Parse(Console.ReadLine());

            Console.WriteLine("Following is your enter number: {0}", num);

            Console.ReadLine();
        }
    }
}

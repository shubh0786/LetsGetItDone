using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//6) Write a Program to Swap Two Numbers

namespace Number_6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n1 = 32, n2=23;
            int n3; 

            n3 = n1;
            n1 = n2;
            n2 = n3;

            Console.WriteLine("swapped numbers {0} {1}", n1,n2 );

            Console.ReadLine();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindingLargestNum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1,n2,n3;

       


            Console.WriteLine("Please enter your number");
            n1 = int.Parse(Console.ReadLine());


            Console.WriteLine("Please enter your number");
            n2 = int.Parse(Console.ReadLine());



            Console.WriteLine("Please enter your number");
            n3 = int.Parse(Console.ReadLine());


            if (n1>n2 && n1>n3)
            {

                Console.WriteLine("{0} is the largest number",n1);

            } else if (n2>n1 && n2 > n3)
            {
                Console.WriteLine("{0} is the largest number",n2);
            }
            else
            {
                Console.WriteLine("{0} is the largest number",n3);
            }

            Console.ReadLine();
        }
    }
}

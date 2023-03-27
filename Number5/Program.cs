using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//5) Write a Program to Find Size of int, float, double and char
//in your computer


namespace Number5
{
    internal class Program
    {
  
        
        static void Main(string[] args)
        {

  

            Console.WriteLine("Following are the types {0}", sizeof(char));
            Console.WriteLine("Following are the types {0}", sizeof(int));
            Console.WriteLine("Following are the types {0}", sizeof(float));
            Console.WriteLine("Following are the types {0}", sizeof(double));


            Console.ReadKey();

        }
    }
}

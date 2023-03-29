using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a Program to Check Whether a Character isVowel or Consonant

namespace ChrOrVowel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char ch;

            Console.WriteLine("Please enter your chracter");

            ch = Char.ToLower(Console.ReadKey().KeyChar);

            Console.WriteLine("\n");

            if (ch == 'a'|| ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
            {
                Console.WriteLine("{0} is a vowel",ch);
            }
            else
            {
                Console.WriteLine("{0} is consonant",ch);
            }

            Console.ReadLine();
        }
    }
}

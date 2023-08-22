using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String.String_Assignment
{
    //5.	Write a C# program to count total number of words in a string. 
    internal class CountTotalNo
    {
        public static void Main(string[] args)
        {
            string str = "HELLO$WORLD";
            int countwords = 0;
            for (int i = 0; i < str.Length; i++) 
            {
                countwords++;
            }
            Console.WriteLine($"Total Words in String={countwords}");

        }
    }
}

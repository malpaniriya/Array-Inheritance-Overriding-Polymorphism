using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String.String_Assignment
{
    //10.	Write a C# program to find reverse of a string.
    internal class ReverseStringDemo
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter String");
            string str=Convert.ToString(Console.ReadLine());

            for(int i=str.Length-1; i>=0; i--)
            {
                Console.WriteLine(str[i]);
            }
        }
    }
}

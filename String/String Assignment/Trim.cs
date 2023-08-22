using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String.String_Assignment
{
    //4.	Write a C# program to trim leading white space characters in a string.
    internal class Trim
    {
        public static void Main(string[] args)
        {
            string str = "   HELLO$WORLD    ";
            string str1= string.Concat(str.Trim());
            Console.WriteLine(str1);


        }

    }
}

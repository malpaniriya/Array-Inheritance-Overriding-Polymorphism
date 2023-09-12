using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String.String_Assignment
{
    //11.	Write a C# program to reverse order of words in a given string.
    internal class ReverseDemo
    {
        public static void Main(string[] args)
        {
            string str1 = "My name is Riya";
            string[] words = str1.Split(' ');
            string reversedString = " ";

            for(int i=words.Length-1; i>=0; i--)
            {
                reversedString += words[i];
            }
            Console.WriteLine("Reverse order is  "+reversedString);
        }
    }
}

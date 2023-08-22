using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String.String_Assignment
{
    //3.	Write a C# program to count occurrences of a character in given string.
    internal class Count
    {
        public static void Main(string[] args)
        {
            string str= "HELLO$WORLD";
            Console.WriteLine(str.IndexOf('L') + "=1st Occurance of L");

            char[] ch = str.ToCharArray();
            int cnt = 0;
            for (int i = 0; i < ch.Length; i++)
            {
                if (ch[i] == 'L')
                {
                    cnt++;
                }
            }
            Console.WriteLine($"Occurance of L={cnt}");

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String.String_Assignment
{
    //15.Write a C# program to find the duplicate words and their number of occurrences in a string
    internal class DuplicateDemo
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter string");
            string str=Convert.ToString(Console.ReadLine());
            string[] str1 = str.Split(' ');
            int count = 0;

            for(int i=0; i<str1.Length; i++)
            {
                for(int j=i+1; j<str1.Length; j++)
                {
                    if (str1[j] == str1[i])
                    {
                        count++;
                        Console.WriteLine(str1[i]); 
                    }

                }
            }
            Console.WriteLine("Count of duplicate word and the number of occurence is " + count);


        }


    }
}

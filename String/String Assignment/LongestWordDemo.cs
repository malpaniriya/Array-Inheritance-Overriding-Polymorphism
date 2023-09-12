using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String.String_Assignment
{
    //18.WAP to find longest word in the given sentence
    internal class LongestWordDemo
    {
        public static void Main(string[] args)
        {
            string str="Riya Ghanashyam Malpani";
            Console.WriteLine(str);

            string[] str1 = str.Split(' ');
            string longestWord = "";
            int max = 0;
            
            for(int i=0; i<str1.Length; i++)

            {
                int a = str1[i].Length;
                if(a>max ) 
                {
                    max= a; 
                    longestWord=str1[i];


                }
                
                 
            }
            Console.WriteLine(longestWord);


        }

    }
}

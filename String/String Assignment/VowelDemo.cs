using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String.String_Assignment
{
    //9.Write a C# program to count total number of vowels and consonants in a string.
    internal class VowelDemo
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(  "enter string :");
            string str1 =Convert.ToString(Console.ReadLine());
            char[] c = str1.ToCharArray();
            int cnt1 = 0;int cnt2 = 0;


            for (int i = 0; i < str1.Length; i++)
            {
                if (c[i] == 'a' || c[i] == 'e' || c[i] == 'i' || c[i] == 'o' || c[i] == 'u'
                    || c[i] == 'A' || c[i] == 'E' || c[i] == 'I' || c[i] == 'O' || c[i] == 'U')
                {
                    cnt1++;
                }
            
                else 
                {
                    cnt2++;
                }

            }
            Console.WriteLine("Vowels count :" + cnt1);
            Console.WriteLine( "Consonant :" +cnt2 );
        }
    }
}


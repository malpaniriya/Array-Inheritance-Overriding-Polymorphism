using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String.String_Assignment
{

    //13.	Write a C# program to find total number of alphabets, digits or special character in a string.
    internal class TotalNumberAlphaDigits
    {
        public static void Main(string[] args)
        {
            string str ="Riya@12343";
            Console.WriteLine(str);
            int count1 = 0;
            int count2 = 0;
            int count3 = 0;

            char[]ch=str.ToCharArray();

            for(int i=0; i<ch.Length; i++)
            {
                if ((ch[i]>='a' && ch[i]<='z') || (ch[i]>='A' && ch[i]<='Z'))
                {
                   count1++;
                }
                else if(ch[i] >= '0' && ch[i] <= '9')
                {
                    count2++;

                }
                else
                {
                    count3++;


                }
            }
            Console.WriteLine("Total Alphabet "+count1);
            Console.WriteLine("Total Digit "+count2);
            Console.WriteLine("Total special Character "+count3 );




        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
    internal class ReverseStringDemo
    {
        public static void Main(string[] args)
        {
            string str = "India is the best";
            string str1 = " "; 
            for(int i=str.Length-1; i>=0; i--)
            {
                str1 = str + str[i];
            }
           





        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String.String_Assignment
{
    //1.	WAP to split string into 2 tokens where string is “HELLO$WORLD”
    internal class SplitHelloWorld
    {
        public static void Main(string[] args)
        {
            string str = "HELLO$WORLD";
            

            string[] sarray = str.Split('$');
            Console.WriteLine(sarray[0]);
            Console.WriteLine(sarray[1]);
           
        }
    }
}

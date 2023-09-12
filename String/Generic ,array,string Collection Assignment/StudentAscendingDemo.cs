using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String.Generic_Collection_Assignment
{
    internal class StudentAscendingDemo
    {
        //2.WAP to create an array of 5 strings to store students name, sort names in ascending order & display using foreach loop.
        public static void Main(string[] args)
        {
            
            List<string> list = new List<string>();
            list.Add("Riya");
            list.Add("Vinayak");
            list.Add("Shruti");
            list.Add("Anoushka");
            list.Add("Ruturaj");
            list.Sort();

            foreach(string s in list)
            {
                Console.WriteLine(s);
            }


        }
    }
}

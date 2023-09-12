using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String.Generic_Collection_Assignment
{
    //1.WAP to create an array of 5 integers. Initialize 5 values. Display using foreach loop..
    internal class Array5IntDemo
    {
        public static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            List<int> list = new List<int>();
            foreach (int i in arr)
            {
                Console.WriteLine(i);

            }

        }
    }
}


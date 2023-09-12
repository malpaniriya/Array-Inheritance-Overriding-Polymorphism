using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String.Array_Lab_Assignment
{
    //WAC to display alternate element from the array
    internal class AlternateElement
    {
        public static void Main(string[] args)
        {
            int[] a = new int[] { 1,2,3,4,5,6,7,8 };


            for (int i = 0; i < a.Length; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(a[i]);
                }

            }




        }
    }
}

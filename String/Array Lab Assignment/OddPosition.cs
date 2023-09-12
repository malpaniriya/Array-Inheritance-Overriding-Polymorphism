using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String.Array_Lab_Assignment
{
    //WAC to create array and display odd position element from the array
    internal class OddPosition
    {
        public static void Main(string[] args)
        {
            int[] a = new int[] {1,4,7,9,4,5,2 };

            
            for (int i=0;i<a.Length;i++)
            {
                if(i%2!=0)
                {
                    Console.WriteLine(a[i]);
                }

            }

        }
    }
}

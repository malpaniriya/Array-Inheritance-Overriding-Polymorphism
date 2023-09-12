using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String.Array_Lab_Assignment
{
    internal class SumOfEven
    {
        //WAC to create int type of array and calculate a sum of even element from the array
        public static void Main(string[] args)
        {

            int[] a = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, };
            int sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 == 0)
                {
                    sum = sum + a[i];
                }


            }
            Console.WriteLine(sum);
        }
    }
}

            
       
        
    


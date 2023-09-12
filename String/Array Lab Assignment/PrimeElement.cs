using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String.Array_Lab_Assignment
{
    //WAC to display prime element from the array
    internal class PrimeElement
    {
        public static void Main(string[] args)
        {
            int[] a = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            
            
            for (int i = 0; i < a.Length; i++)
            {
                int count = 0;
                for (int j = 2; j < a[i];j++)
                {
                    if (a[i] % j == 0)
                    {
                        count++;
                        break;
                       

                    }

                }
                if(count == 0)
                {
                    Console.WriteLine(a[i]);

                }
            }
            
        }
    }
}

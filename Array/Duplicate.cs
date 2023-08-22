using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixthProject.Array
{
    //	WAP to find and count total number of duplicate elements in an array.
    public class Duplicate
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 2, 3, 5, 6, 4, 7, 8, 9, 9 };
            int count = 0; 

           

            Console.WriteLine("Duplicate number in the array");

            for (int i = 0; i < array.Length; i++)

            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        count++;
                        Console.WriteLine(array[i]);








                    }
                }
          
            }
            Console.WriteLine(count);
        }
    }
}

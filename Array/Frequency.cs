using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixthProject.Array
{
    //WAP to count frequency of each element in an array.
    public class Frequency
    {
        public static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 2, 3, 5, 6, 4, 7, 8, 9, 9, 3, 3 };
            Console.WriteLine("Frequency number in array");

            for (int i = 0; i < array.Length; i++)
            {
                int count = 1;
                bool isvisted = false;
                for (int k = i - 1; k >= 0; k--)
                {
                    if (array[k] == array[i])
                    {
                        isvisted = true;
                        break;
                    }
                }
                if (isvisted == false)
                {
                    for (int j = i + 1; j < array.Length; j++)
                    {
                        if (array[i] == array[j])
                        {
                            count++;
                        }

                    }
                   
                    

                      Console.WriteLine(array[i] + "count" + count);
                    
                }
            }
        }
    }
}

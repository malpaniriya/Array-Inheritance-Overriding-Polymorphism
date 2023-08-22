using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixthProject.Array
{
    //WAP to print all negative elements in an array and also count the total number of negative elements in an array.


    public class NegativeElementsandCountofnegativeelements
    {
        static void Main(string[] args)
        {
            int[] negative = new int[10];
            int count = 0;
            for(int i=0; i<negative.Length; i++)
            {
                Console.WriteLine("Enter a number");
                negative[i] = Convert.ToInt32(Console.ReadLine());
            }

            for(int i=0; i<negative.Length ; i++)

            {
                if (negative[i] < 0)
                {
                    Console.WriteLine(negative[i] + "Is a negative number");
                    count++;
                    
                    
                  
                }

            }
            Console.WriteLine(count);
            count++;

        }
    }
}

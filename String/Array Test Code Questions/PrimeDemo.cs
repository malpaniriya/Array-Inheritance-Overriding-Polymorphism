using String.Array_Lab_Assignment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String.Array_Test_Code_Questions
{
    internal class PrimeDemo
    {
        public static void Main(string[] args)
        {
            int[] array = new int[] { 1, 2, 3, 4, 5,6,7,8,9,10 };
            int sum = 0;
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                bool isPrime = true;
                for (int j = 2; j < array[i]; j++)
                {
                    isPrime = false;
                    break;
                }
                if (isPrime)
                {
                    Console.WriteLine(array[i]);
                    sum = sum + array[i];
                    count++;
                }

            }
            double avg = (double)(sum) / count;
            Console.WriteLine("Avg of prime no:" + avg);

        }
    }
}



                
            


    


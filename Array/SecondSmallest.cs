using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixthProject.Array
{
    //WAP to find the second smallest element in an array.
    public class SecondSmallest
    {
        public static void Main(string[] args)
        {
            int[]array=new int[5];
            for (int i = 0; i < array.Length; i++)
            {

                Console.WriteLine("Enter a Number");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            int small = int.MaxValue;
            int small2= int.MinValue; 
            for(int i=0;i<array.Length;i++)
            {
                if (array[i]<small)
                {
                    small2 = small;
                    small= array[i];
                }
                if (array[i] > small && array[i] < small2)
                {
                    small2= array[i];
                }
            }
            Console.WriteLine($"2nd smallest number is {small2}");





        }
    }
    }



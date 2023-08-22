using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixthProject.Array
{
    public class MinMax
    {
        public static void Main(string[] args)
        {
            int[] array = new int[5];
            for(int i=0;i<array.Length; i++)
            {
                Console.WriteLine("Enter a Number");
                array[i] =Convert.ToInt32(Console.ReadLine());
            }
            int max = array[0];
            for(int i=0 ; i<array.Length ; i++)
            {
                if (array[i]>max)
                {
                    max= array[i];
                }
            }
            Console.WriteLine(max);
            int min= array[1];
            for(int i=0 ; i<array.Length ;i++)
            {
                if (array[i]<min)
                {
                    min= array[i];
                }
            }
            Console.WriteLine(min);
        }
    }
}

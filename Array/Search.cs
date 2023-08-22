using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixthProject.Array
{
    public class Search
    {
        public static void Main(string[] args)
        {
            int[] array = new int[5];
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Enter a Number");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Enter a number to search");
            int num = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == num)
                {
                    Console.WriteLine($"{num} found at {i}");

                }

            }
    }


        

}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String.Array_Lab_Assignment
{
    internal class NumberSearchDemo
    {
        public static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8};
            Console.WriteLine("Enter a Number");
            int a = Convert.ToInt32(Console.ReadLine());
            bool isfound = false;
            int index = -1;


            for(int i=0;i<arr.Length; i++)
            {
                if (arr[i] == a)
                {
                    isfound = true;
                    index = i;
                }

               
            }
            if (isfound)
            {
                Console.WriteLine($"{a} found at {index} index");


            }
            else
            {
                Console.WriteLine("Not Present");
            }
            

        }
    }
}

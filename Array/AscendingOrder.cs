using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixthProject.Array
{
    //declare an array of 5 elements & sort it in asc order and decending order

    public class AscendingOrder
    {
        static void Main(string[] args)
        {
            int[] arr = { 45, 67, 12, 89, 5 };
            for(int i=0; i<arr.Length; i++)
            {
               for(int j=0;j<arr.Length;j++)
                {
                    if (arr[i]< arr[j])
                    {
                        int temp;
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            Console.WriteLine("Ascending Order");
            foreach(int i in arr)
            {
                Console.WriteLine(i);
            }
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int temp;
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            Console.WriteLine("Decending Order");
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }





        }
    }
}

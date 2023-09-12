using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace String.Array_Test_Code_Questions
{
    internal class MaxCharDemo
    {
        //find the max char from the string
        static void Main(string[] args)
        {
            char[] arr = { 'a', 'b', 'c', };
            char maxChar = arr[0];
            for(int i=1; i<arr.Length; i++)
            {
                if (arr[i] > maxChar)
                {
                    maxChar= arr[i];
                }
            }
            Console.WriteLine("The Maximum character is "+maxChar);



        }
       

    }
}

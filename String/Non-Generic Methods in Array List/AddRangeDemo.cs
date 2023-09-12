using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String.Methods_in_Array_List
{
    internal class AddRangeDemo
    {
        public static void Main(string[] args)
        {
            int[] arr = new int[] { 67, 45, 12, 78 };
            ArrayList list = new ArrayList();
            list.Add(11);
            list.Add(12);
            list.Add(38);

            //using Insert Method
            //list.Insert(1, 1.5);

            //using Add range method

            list.AddRange(arr);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}

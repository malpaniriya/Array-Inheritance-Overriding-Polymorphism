using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String.Hastable_Programs
{
    internal class SortedListDemo
    {
        //Implement dept id ,dept name using shortedList
        public static void Main(string[] args)

        {
            SortedList st=new SortedList();
            st.Add(102,"HR");
            st.Add(101,"Information Technology");

            foreach(DictionaryEntry item in st)
            {
                Console.WriteLine($"{item.Key} {item.Value}");
        }

        }
    }
}

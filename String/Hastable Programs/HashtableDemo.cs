using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String.Hastable_Programs
{
    //Implement country code and conyty name using hashtable
    internal class HashtableDemo
    {
        public static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add(101, "Finland");
            ht.Add  (102,"Europe");

            //used Remove also

            ht.Remove(101);

            foreach (DictionaryEntry item in ht)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }

        }
    }
}

using String.String_Assignment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String.Lab_assignment_of_generic_collection
{
    //Create a list and remove duplicate from list
    internal class DuplicateDemo
    {
        public static void Main(string[] args)
        {
            List<string> list = new List<string>();
            list.Add("Riya");
            list.Add("Shruti");
            list.Add("Riya");
            list.Add("Vinayak");
            
            for(int i=0; i<list.Count; i++)
            {
                for(int j=i+1; j<list.Count; j++)
                {
                    if (list[i].Equals(list[j])) 
                    {
                        list.Remove(list[i]);

                    }

                }
                Console.WriteLine(list[i]);
            }
            



        }

    }
}

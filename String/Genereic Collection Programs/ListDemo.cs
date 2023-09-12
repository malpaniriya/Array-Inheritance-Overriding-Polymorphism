using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String.Genereic_Collection_Programs
{
    internal class ListDemo
    {
        public static void Main(string[] args)
        {
            //list

            //add
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            
            //insert
           
            list.Insert(0, 100);
           

            //sort
            
            list.Sort();
            
            //reverse
            
            list.Reverse();
            

            //Remove
            
            list.Remove(0);
            

            //count
           
            list.Count();
                

            //clear
            
            //list.Clear();
            foreach (int i in list)
                    Console.WriteLine(i);

            


            
                
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String.Genereic_Collection_Programs
{
    internal class HashsetDemo
    {
        static void Main(string[] args)
        {
            HashSet<string> list = new HashSet<string>();
            list.Add("Pune");
            list.Add("Mumbai");
            list.Add("Nagpur");
            list.Add("Pune");

            list.Remove("Nagpur");
            list.Clear();

            
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}

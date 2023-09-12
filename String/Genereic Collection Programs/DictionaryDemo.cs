using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String.Genereic_Collection_Programs
{
    internal class DictionaryDemo
    {
        public static void Main(string[] args)
        {
            Dictionary<string,string> dic = new Dictionary<string,string>();
            dic.Add(".docx", "Word file");
            dic.Add(".xlsx", "Excel file");
            dic.Add(".cs", "C# file");

            foreach(KeyValuePair<string,string> item in dic)
            {
                Console.WriteLine($"{item.Key} {item.Value}");
            }

            Dictionary<int,string> dic2 = new Dictionary<int,string>();
            dic2.Add(101, "HR");
            dic2.Add(102, "Sales");
            dic2.Add(103, "Marketing");

            dic2.Remove(101);

            foreach (KeyValuePair<int,string> item in dic2)
            {
                Console.WriteLine($"{item.Key} {item.Value}");
            }

            Dictionary<int,string> dic3= new Dictionary<int,string>();
            dic3.Add(111, "Finland");
            dic3.Add(222, "Europe");
            dic3.Add(333, "India");

            dic3.Remove(111);

            foreach( KeyValuePair<int,string> item in dic3)
            {
                Console.WriteLine($"{item.Key} {item.Value}");
            }    
        }
    }
}

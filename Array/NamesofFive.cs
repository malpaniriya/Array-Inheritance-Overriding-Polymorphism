using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixthProject.Array
{
    //print 5 names using foreach loop
    public class NamesofFive
    {
        public static void Main(string[] args)
        {
            string[] name = new string[5];
            for (int i = 0; i < name.Length; i++)
            {
                Console.WriteLine("Enter Name");
                name[i] = Console.ReadLine();
            }
            {
                foreach (var r1 in name)
                {
                    Console.WriteLine(r1);

                }
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixthProject.Array
{
    //WAP to accept 5 names using 1D array and display using for loop

    public class FiveNames
    {
       public  static void Main(string[] args)
        {
            string[] name = new string[5];
            for (int i=0;i<name.Length;i++)
            {
                Console.WriteLine("Enter Name");
                name[i] = Console.ReadLine();

            }
            {
                for (int i = 0; i < name.Length; i++)
                {
                    Console.WriteLine(name[i]);
                }

            }
        }
    }
}

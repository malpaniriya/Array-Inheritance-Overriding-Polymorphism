using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixthProject.Array
{
    //WAP to accept number from the user and print only even numbers
    public class Printonlyevennumbers
    {
        static void Main(string[] args)
        {
            int[] num = new int[10];
            for (int i=0; i < 10; i++)
            {
                num[i] = Convert.ToInt32(Console.ReadLine());

            }

            for (int i = 0; i < 10; i++)
            {
                if (num[i] % 2 == 0)
                {
                    Console.WriteLine(num[i] + "Is Even Number");
                }

            }
                

        }
        
    }
}

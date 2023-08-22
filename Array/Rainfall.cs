using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixthProject.Array
{
    public class Rainfall
    {
        static void Main(string[] args)
        {
            
            double[] days = new double[7];

            for (int i = 0; i < days.Length; i++)
            {
                days[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Rainfall in week");
            for (int i = 0; i < days.Length; i++) 
            {
                Console.WriteLine($"days[{i}]= {days[i]}");
            }


        }
    }
}

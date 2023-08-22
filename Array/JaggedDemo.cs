using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixthProject.Array
{
    public class JaggedDemo
    {
        public static void Main(string[] args)
        {
            int[][] jarray = new int[5][];

            jarray[0] = new int[5];
            jarray[1] = new int[4];
            jarray[2] = new int[3];
            jarray[3] = new int[2];
            jarray[4] = new int[1];

            for (int row = 0; row < jarray.Length; row++)
            {
                for (int col = 0; col < jarray[row].Length; col++)
                {
                    Console.WriteLine("Enter Number");
                    jarray[row][col] = Convert.ToInt32(Console.ReadLine());
                }

            }

            for (int row = 0; row < jarray.Length; row++)
            {
                for (int col = 0; col < jarray[row].Length; col++)
                {
                    Console.Write(jarray[row][col] + "  ");
                }
                Console.WriteLine("\n");

            }






        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixthProject.Array
{
    public  class Initialize
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[4, 5]
            {
                {1,2,3,4,5 },
                {6,7,8,9,10 },
                {11,1,13,14,15 },
                {16,17,18,19,20 },
               };

            for(int row=0;row<arr.GetLength(0); row++)
            {
                for(int col=0;col<arr.GetLength(1); col++)
                {
                    Console.Write($"arr[{row},{col}]={arr[row,col]}");
                }
                Console.WriteLine("\n");
            }




            }
        }
    }


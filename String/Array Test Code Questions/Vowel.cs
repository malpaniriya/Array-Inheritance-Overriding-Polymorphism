using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String.Array_Test_Code_Questions
{
    internal class Vowel
    {
        public static void Main(string[] args)
        {

            char[] arry = { 'a', 'e', 'i', 'm', 'o', 'u', 'b', 'z' };
            Console.WriteLine("Enter Character");
            string vowels = " ";

            for (int i = 0; i < arry.Length; i++)
            {


                if (arry[i] == 'a' || arry[i] == 'e' || arry[i] == 'i' || arry[i] == 'o' || arry[i] == 'u') ;
                {
                    vowels = vowels + arry[i];
                    Console.WriteLine(arry[i]);



                }
                Console.WriteLine("Vowels in the array are");

            }
        }
    }
}

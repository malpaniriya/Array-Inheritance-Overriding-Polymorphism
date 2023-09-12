using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String.String_Assignment
{
    internal class ToggleDemo
    {
        //8.Write a C# program to toggle case of each character of a string.
        public static string ToggleCharacter(string str)
        {
            
            char[] charArray = str.ToCharArray();

            for (int i = 0; i < charArray.Length; i++)
            {
                if (charArray[i] >= 65 && charArray[i] <= 91)
                {
                    int a = (int)charArray[i] + 32;
                    charArray[i] = (char)a;


                }
                else
                {
                    int A = (int)charArray[i] - 32;
                    charArray[i] = (char)A;
                }
            }
            string str1 = new string(charArray);
            return str1;



        }
        public static void Main(string[] args)
        {
            string str1 = "MaLpAnI";
            Console.WriteLine(ToggleCharacter(str1));
        }
    }
   
    

       
            



            }
            


        
    


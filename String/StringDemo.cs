using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
    internal class StringDemo
    {
        public static void Main(string[] args)
        {
            string message = "Good ";
            string message2 = "Morning";

            //methods of string class
            string str = string.Concat(message, " ", message2.TrimEnd());
            Console.WriteLine(str);
            Console.WriteLine(str.Trim());

            Console.WriteLine(str.ToUpper ()+"Upper case");
            Console.WriteLine(str.ToLower()+"Lower Case");

            Console.WriteLine("index  - " + message.IndexOf('o'));
            Console.WriteLine("last index" + message2.LastIndexOf('o'));

            string[] sarray = str.Split(' ');
            Console.WriteLine(sarray[0] + "print sarrat");
            Console.WriteLine(sarray[1] + "print sarray");

            char[]ch= message.ToCharArray();
            Console.WriteLine(ch[0]);

            string str2= new string(ch);
            Console.WriteLine(str2);

            foreach (char c in ch)
            {
                Console.WriteLine(c);
            }
            foreach (string s in sarray)
            {
                Console.WriteLine(s);
            }

            for (int i = 0; i < message2.Length; i++)
            {
                Console.WriteLine(message2[i]);
            }
        }









    }
}


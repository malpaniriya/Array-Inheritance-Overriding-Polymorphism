using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String.String_Builder_Programs
{
    internal class String_Builder_Method_Demo
    {
        public static void Main(string[] args)
        {
            StringBuilder strbuilder = new StringBuilder("Hello to all");
            Console.WriteLine(strbuilder);

            strbuilder.Append("Good Morning");
            Console.WriteLine(strbuilder);

            strbuilder.Remove(4, 5);
            Console.WriteLine(strbuilder);

            strbuilder.Replace('l', 'L');
            Console.WriteLine(strbuilder);

            strbuilder.Replace("all", "everyone");
            Console.WriteLine(strbuilder);

            Console.WriteLine("Capacity =" + strbuilder.Capacity);

            strbuilder.Clear();// remove all the letters / strbuilder will be empty

            Console.WriteLine(strbuilder);


        }

    }
}

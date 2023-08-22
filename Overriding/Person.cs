using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixthProject.Overloading
{
    //WAP to create class Person with method readScript().
    //create class Actor which extends Person implement readScript() differently in child.
    public class Person
    {
        public  virtual void ReadScript()
        {
            Console.WriteLine("It is the parent class");
        }


    }
    public class Actor: Person
    {
        public override void ReadScript()
        {
            Console.WriteLine("It is child class");
        }

        public static void Main(string[] args)
        {
            Actor a=new Actor();
            a.ReadScript();
        }
    }
}

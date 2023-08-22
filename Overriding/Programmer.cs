using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixthProject.Overloading
{
    //WAP to create class Programmer with Method workingHours().
    //create class Employee which extends Programmer implement workingHours()differently in child.
    public class Programmer
    {
        public virtual void Workinghours()
        {
            Console.WriteLine("Working hour for programmer");
        }

    }
    public class Employee:Programmer
    {
        public override void Workinghours()
        {
            Console.WriteLine("Working hour for employee");
        }

        public static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.Workinghours();
        }
    }
}

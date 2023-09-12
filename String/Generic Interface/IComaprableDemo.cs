using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String.Generic_Interface
{
    internal class IComaprableDemo
    {
        public class Employee
        {
            public string Name { get; set; }
            public int Salary { get; set; }
        }

        public class CheckSalary:IComparer<Employee>
        {
            public int Compare(Employee x, Employee y)
            {
                if(x.Salary>y.Salary)
                {
                    return 1;
                }

                 else if (x.Salary < y.Salary)
                {
                    return -1;
                    
                }
                else
                {
                    return 0;
                }
            }
        }
        public class Program
        {
            static void Main(string[] args)
            {
                Employee emp1 = new Employee { Name = "Riya Malpani", Salary = 50000 };
                Employee emp2 = new Employee { Name = "Yash Shah", Salary = 40000 };

                CheckSalary check=new CheckSalary();
                int result=check.Compare(emp1, emp2);
                if (result == 1 )
                {
                    Console.WriteLine("Riya Malpani has more salary then Yash Shah");
                }
                else if(result==-1)
                {
                    Console.WriteLine("Riya Malpani has less salary than Yash Shah");
                }
                else
                {
                    Console.WriteLine("Riya Malpani and Yash Shah has equal salary");
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
    internal class Employee2
    {
        int id;
        string name;
        int salary;

        public Employee2(int id, string name, int salary)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;

        }
        public override string ToString()
        {
            return $"{id},{name},{salary}";
        }
        public static void Main(string[] args)
        {
            Employee2[] emp = new Employee2[3];
            for (int i = 0; i < emp.Length; i++)
            {
                Console.WriteLine("Enter Id");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Name");
                string name = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Enter Salary");
                int salary = Convert.ToInt32(Console.ReadLine());
                emp[i] = new Employee2(id, name, salary);

            }
            for (int i = 0; i < emp.Length; i++)
            {
                if (emp[i].salary > 20000)
                {
                    Console.WriteLine(emp[i]);
                }

            }
        }


    }
}

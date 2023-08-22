using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace String
{
    public class Employee1
    {
        int ID;
        string Name;
        public int salary;

        public Employee1(int ID, string Name, int salary)
        {
            this.ID = ID;
            this.Name = Name;
            this.salary = salary;
        }
        public override string ToString()
        {
            return $"{ID},{Name},{salary}";
        }
    }
        public static void Main(string[] args)
        {
            Employee[] emp = new Employee[3];
            for (int i = 0; i < emp.Length; i++)
            {
                Console.WriteLine("Enter Id");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Name");
                string name = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Enter Salary");
                int salary = Convert.ToInt32(Console.ReadLine());
                emp[i] = new Employee(id, name, salary);

            }
            for (int i = 0; i < emp.Length; i++)
            {
                if (emp[i].
                {
                    Console.WriteLine(emp[i]);

                }
                
            }
           







        }
    }
}
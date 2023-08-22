using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
    public class Employee
    {
        int Id;
        string Name;
        int salary;

        public Employee(int Id, string Name, int salary)
        {
            this.Id = Id;
            this.Name = Name;
            this.salary = salary;
        }
        public override string ToString()

        {
            return $"{Id},{Name},{salary}";

        }
        public static void Main(string[] args)
        {
            //Employee[] emp = new Employee[3];
            //emp[0] = new Employee(101, "Riya", 70000);
            //emp[1] = new Employee(102, "Shruti", 60000);
            //emp[2] = new Employee(103, "Aditya", 50000);

            //foreach (Employee e in emp)
            //{
            //    Console.WriteLine(e);
            //}
            // How to take input from user

            Employee[] emp = new Employee[3];
            for(int i=0;i<emp.Length;i++)
            {
                Console.WriteLine("Enter Id");
                int id=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Name");
                string name=Convert.ToString(Console.ReadLine());
                Console.WriteLine("Enter Salary");
                int salary=Convert.ToInt32(Console.ReadLine());
                emp[i]=new Employee(id, name, salary);

            }
            for (int i = 0; i < emp.Length; i++)
            {
                Console.WriteLine(emp[i]);
            }
        }
    }
}





            
        
        
    


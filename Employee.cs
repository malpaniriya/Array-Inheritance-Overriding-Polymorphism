using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixthProject
{
    public class Employee
    {
        // Create Employee class --> with id,name,department,salary accept the data & display emp details
        private int id;
        private double salary, hra,da,ta,pf,gross;
        private string name, department;
        private static int count;
        private static int GetEmpcount;


        public Employee()
        {
            id = 0;
            name = "";
            salary = 0.0;

        }
        public Employee(int id, string name, double salary)
        {
            count++;
            this.id = count;
            this.name = name;
            this.salary = salary;

        }


        public void AcceptEmployee(int id, double salary, string name, string department)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
            this.department = department;

        }
        public static int GetEmpCount()
        {
            return count;
            
        }

        public void CalculateSalary()
        {
            hra = salary * 0.40;
            da = salary * 0.20;
            ta = salary * 0.10;
            pf = salary * 0.12;
            gross = (salary + hra + da + ta) - pf;


        }
        public string PrintEmployee()
        {
            return $"Emp id = {id}\n,Name={name}\n,Basic Salary={salary}\n,Department={department}\n,Gross={gross}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixthProject.Array
{
    public enum Designation { Traine,Manager,CEO, Employee};
    public enum Department { HR,Admin,Dev,Testing,Marketing};
    public class Employee10
    {
        public int id;
        public string name;
        public float salary;
        public Designation designation;
        public Department department;


        public Employee10(int id,string name,float salary, Designation designation,Department department)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
            this.designation = designation;
            this.department = department;
        }

        public override string ToString()
        {
            return $"{id} {name} {salary} {department} {designation}";
        }
        public class EnumDemo
        {
            public static void Main(string[] args)
            {
                Employee10 e=new Employee10(101,"Riya Malpani",50000,Designation.Manager,Department.HR);
                Console.WriteLine(e);
                Employee10 e1=new Employee10(102,"Yash Shah",40000,Designation.Traine,Department.Admin);
                Console.WriteLine(e1);
                
            }
        }
    }

}

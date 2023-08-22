using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixthProject.OOPSDEMO
{
    //lab program no 4 of static
    public class Student1234
    {
        private int id, age;
        private string name, gender, department;
        private static int count;


        public Student1234(int id, string name, int age, string gender, string department)
        {
            count++;
            this.id = count;
            this.name = name;
            this.gender = gender;
            this.age = age;
            this.department = department;
        }

        static Student1234()
        {
            Console.WriteLine("I am static constructor");

        }
        public static int GetStudcount()
        {
            return count;
        }
        public string Display()
        {
            return $"Id:{id},Name: {name},Age: {age},Gender:{gender},Department={department}";
        }

    }
}


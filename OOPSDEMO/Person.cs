using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SixthProject.OOPSDEMO
{
    //lab session
    public class Person1
    {
       
        protected string name, address,gender;
        protected int age;
        protected double hra, da, ta, pf, salary, gross;
        

        public Person1( string name, string gender, string address,int age)
        {
            this.name = name;
            this.gender = gender;
            this.address = address;
            this.age = age;



        }

        public string Dislay()
        {
            return ($" {name} {gender} {address} {age}");
        }

        public class Employee2 : Person1
        {
            private int id;
            public Employee2(string name,string gender,string address,int age,int id):base (name,gender,address,age)
            {
                this.id = id;
            }

            public void CalculateSalary()
            {
                hra = salary * 0.40;
                da = salary * 0.20;
                ta = salary * 0.10;
                pf = salary * 0.12;
                gross = (salary + hra + da + ta ) - pf;
            }


        }

    }




}

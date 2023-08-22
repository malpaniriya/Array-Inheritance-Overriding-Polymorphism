using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixthProject.OOPSDEMO
{
    //Example of inheritance
    public class Employee1
    {
        protected int id;
        protected string name;
        protected double salary, hra, da, ta, pf, gross;
     
            

        public Employee1(int id, string name, double salary)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
            
        }
        public virtual void CalculateSalary()
        {
            hra = salary * 0.40;
            da = salary * 0.20;
            ta = salary * 0.10;
            pf = salary * 0.12;
            gross = (salary + hra + da + ta ) - pf;
        }
        public virtual string Print()
        {
            return $"manager's salary Gross={gross}";
        }
    }
    public class Manager : Employee1
    {
        private double Foodallownce;

        public Manager(double foodallownce, int id,string name, double salary) : base (id,name,salary)
        {
            this.Foodallownce = foodallownce;

        }
        public override void CalculateSalary()
        {
            hra = salary * 0.40;
            da = salary * 0.20;
            ta = salary * 0.10;
            pf = salary * 0.12;
            gross = (salary + hra + da + ta + Foodallownce) - pf;
        }

        public override string Print()
        {
            return $"manager's salary Gross={gross}";
        }


        }

        
        
        
        

    }




      
           

                

        

        

    


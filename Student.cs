using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixthProject
{
    //create student class with rollno, name,percentage,branch accept the data &display details of student

    // create class Student contains rollno, name & 3 subject marks, calculate total & percentage. display student details
    public class Student
    {
        private int rollno;
        private string name, branch, department;
        private char grade;
        private double marks, m1, m2, m3, total,percentage;

        public Student()
        {
            rollno = 0;
            name = " ";
            branch = " ";
            department = " ";
            grade = ' ';
            marks = 0;
            m1 = 0;
            m2 = 0;
            m3 = 0;
            total = 0;
            percentage = 0;


        }
        public Student(int rollno,string name,string branch,string department,char grade,double marks,double m1,double m2,double m3,double total,double percentage)
        {
            this.rollno = rollno;
            this.name = name;
            this.branch = branch;
            this.department = department;
            this.grade = grade; 
            this.marks = marks;
            this.m1 = m1;
            this.m2 = m2;
            this.m3 = m3;
            this.total = total;
            this.percentage = percentage;

                
        }

        //accpet the marks of three subject and caluclate the total and percentage 

        public void AcceptStudent(int rollno, string name, string branch, string department, double m1,double m2, double m3,double total, double percentage)
        {
            this.rollno = rollno;
            this.name = name;
            this.branch = branch;
            this.m1= m1;
            this.m2= m2;
            this.m3 = m3;
            this.department= department;
            
           
            

        }
        public void CalculateTotal()
        {
            total = m1 + m2 + m3;
            percentage = (total / 300) * 100;
                
            
         
        }
        public void CalculateGrade()
        {
            if(percentage>70)
            {
                Console.WriteLine('A');
            }
            else if(percentage>60)
            {
                Console.WriteLine('B');

            }
            else if(percentage>50)
            {
                Console.WriteLine('C');
            }
        }

        public string PrintStudent()
        {
            return $"Student : {rollno}\n,{name}\n,{branch}\n,{percentage}\n";

        }
    }
}

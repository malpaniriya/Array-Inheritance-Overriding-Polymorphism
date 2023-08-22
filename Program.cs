using SixthProject.OOPSDEMO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SixthProject.OOPSDEMO.Interface;

namespace SixthProject
{

    internal class Program
    {
        static void Main(string[] args)
        {
            //Date dateObj = new Date();
            //dateObj.AcceptDate(4, "Aug", 2023);

            //string res = dateObj.PrintDate();
            //Console.WriteLine(res);

            //Student studentObj1 = new Student();
            //studentObj1.AcceptStudent(12, "Riya", "Pune","IT",70,60,50);
            //studentObj1.CalculateTotal();
            //studentObj1.CalculateGrade();
            //Console.WriteLine(studentObj1.PrintStudent());



            //Employee employeeObj1 = new Employee();
            //employeeObj1.AcceptEmployee(12, 50000, "Riya", "Software Developer");
            //employeeObj1.CalculateSalary();
            //Console.WriteLine(employeeObj1.PrintEmployee());

            //Employee employee1 = new Employee();
            //Employee employee2 = new Employee(1, "Amit", 40000);
            //Employee employee3 = new Employee(2, "Sumit", 50000);

            //employee2.CalculateSalary();
            //employee3.CalculateSalary();
            //Console.WriteLine(employee2.PrintEmployee());
            //Console.WriteLine(employee3.PrintEmployee());
            //Console.WriteLine(Employee.GetEmpCount());

            //Student student = new Student(1, "riya", "pune", "pune", 'A', 300, 100, 100, 100, 300, 100);
            //Student student1 = new Student(2, "shruti", "mumbai", "mumbai", 'B', 300, 250, 100, 100, 50, 95);
            //Student student2 = new Student(3, "aditya", "banglore", "banglore", 'C', 300, 200, 50, 50, 100, 85);
            //Console.WriteLine(student1.PrintStudent());
            //Console.WriteLine(student2.PrintStudent());



            //string res2= employeeObj1.PrintEmployee();
            //Console.WriteLine(res2);
            //Book book = new Book();
            //Book book2 = new Book(102,400,"Secret","Rohnda Byarne" );
            //Book book3 = new Book(103, 500, "The Alchemist", "Paulo Coelho");
            //Console.WriteLine(book2.PrintBook());
            //Console.WriteLine(book3.PrintBook());


            //Book bookObj1 = new Book();
            //bookObj1.AcceptBook(12, 400, "The Alchemist", "Paulo Coelho");

            //string res3 = bookObj1.PrintBook();
            //Console.WriteLine(res3);

            //Console.WriteLine("Enter the default balance");
            //double bal = Convert.ToDouble(Console.ReadLine());
            //Bank b1 = new Bank(10011, "Riya Malpani", bal);
            //Console.WriteLine(b1.Print());
            //b1.Credit(2300.50);

            //Console.WriteLine(b1.Print());

            //string msg = b1.Debit(17301);
            //Console.WriteLine(msg);
            //Console.WriteLine(b1.Print());

            //Student1 stud = new Student1();
            //stud.RollNo = 1;
            //stud.Name = "Riya Malpani";
            //stud.Percentage = 80;
            //Console.WriteLine($"{stud.RollNo}{stud.Name}{stud.Percentage}");
            //Console.WriteLine(stud.Print());

            ////using object initilizer
            //Student1 stud2 = new Student1() { Name = "Riya Malpani", RollNo = 1, Percentage = 80 };
            //Console.WriteLine($"{stud2.Name}{stud2.RollNo}{stud2.Percentage}");

            //Product1 pro=new Product1();
            //pro.Code = 101;
            //pro.Name = "iphone";
            //pro.Price = 75000;
            //Console.WriteLine($"{pro.Code}\n {pro.Name}\n {pro.Price}\n");

            ////using object initializer
            //Product1 pro1 = new Product1() { Code = 101, Name = "iphone", Price = 75000 };
            //Console.WriteLine($"{pro1.Code}\n {pro1.Name}\n {pro1.Price}\n");



            //Movie movie1 = new Movie(1, "DDLJ");
            //Console.WriteLine(movie1.Display());
            //movie1.findAvailableTickets();
            //movie1.Details();

            //program of Method Overloading

            //Calculation c = new Calculation();
            //Console.WriteLine(c.Addition(10,20,30));
            //Console.WriteLine(c.Addition(10,40));
            //Console.WriteLine(c.Addition(10,30.2));
            //Console.WriteLine(c.Addition(1.2,3.2));

            //companyname parameter is optional
            //Car c1 = new Car("i20", 670000);
            //c1.Accept("i10");
            //c1.Accept("honda city", "Honda");
            //// if you pass the parameter then value will be modified for companyname
            //Car c2 = new Car("Ameze", 7700000, "Honda");
            //Console.WriteLine(c1.Print());
            //Console.WriteLine(c2.Print());


            //1) Student2 stud = new Student2(102, "Shruti");
            //   Console.WriteLine(stud.Accept());

            //2) Student3 student = new Student3();
            //   student.DisplayData();


            // Manager m1 = new Manager(200, 10, "RIYA", 35000);

            //below is the main function of concept inheritance
            // Patient p= new Patient(10,"A+","Riya","Prabhat Road",647385645610);
            //  p.show();

            //Employee1 e1 = new Employee1(10, "Riya", 55000);
            //e1.CalculateSalary();
            //Console.WriteLine(e1.Print());


            //Rectangle r1 = new Rectangle(8,4);
            //Console.WriteLine(r1.Display());
            //r1.Area();
            //Console.WriteLine(r1.Draw("It is Rectangle"));
            //Console.WriteLine(r1.Print());

            //User user1= new User();
            //Console.WriteLine(user1.Print());

            //{
            //    ICustomer c1 = new Transaction();
            //    Console.WriteLine(c1.Display());

            //    IOrders o1 = new Transaction();
            //    Console.WriteLine(o1.Display());
            //}

            {
                //    Calc c1 = new Calc();
                //    Console.WriteLine(c1.Multiply(10,5));
            }

            //Calc c2= new Calc();
            //Console.WriteLine(c2.Square(2));

            //Dell l = new Dell(101, "Dell", "Black");
            //Console.WriteLine(l.Display());

            //IDress d1 = new Transactions();
            //Console.WriteLine(d1.Display());
            //IOrder o1 = new Transactions();
            //Console.WriteLine(o1.Display());

            //Student1234 s1 = new Student1234(101, "Riya", 23, "Female", "IT");
            //Student1234 s2 = new Student1234(102, "Shruti", 28, "Female", "Lawyer");
            //Console.WriteLine(s1.Display());
            //Console.WriteLine(s2.Display());
            //Console.WriteLine(Student1234.GetStudcount());
            //s1.Display();
            //s2.Display();

           

            {


            }
        }
    }
}


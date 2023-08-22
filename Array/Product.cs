using SixthProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixthProject.Array
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int price { get; set; }
    }
    public class Employee
    {
        public int id { get; set; }
        public string name { get; set; }

        public int salary { get; set; }
    }
    public class Book
    {
        public int id { get; set; }
        public string name { get; set; }

        public int price { get; set; }
    }


    public class Program
    {
        public static void Main(string[] args)
        {
            Product[] list = new Product[3]
            {
        new Product{Id=1, Name="Mouse",price=300},
        new Product{Id=2, Name="Marker",price=30},
        new Product{Id=3, Name="Pen",price=10}

            };

            foreach (Product p in list)
            {
                Console.WriteLine($"{p.Id} {p.Name} {p.price}");
            }

            Employee[] list1 = new Employee[3]
            {
        new Employee{id=1, name="Mouse",salary=30000},
        new Employee{id=2, name="Marker",salary=40000},
        new Employee{id=3, name="Pen",salary=50000}

            };
            foreach (Employee e in list1)
            {
                Console.WriteLine($"{e.id} {e.name} {e.salary}");
            }
            Book[] list2 = new Book[3]
            {
        new Book{id=1, name="Alchemist",price=300},
        new Book{id=2, name="Secret",price=400},
        new Book{id=3, name="Cindrella",price=500}

            };
            foreach (Book b in list2)
            {
                Console.WriteLine($"{b.id} {b.name} {b.price}");
            }




        }
    }
} 

    
    

    

    
using SixthProject.OOPSDEMO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SixthProject.Polymorphism
{
 //WAJP2 create a class Kid with method readBook() and another method
 //readBook() with 2 parameters.The method readBook here is over-loaded(same
 //method name but different parameters)
 //Create a class BigKid which extends Kid created above. Implement readBook()
 //differently in BigKid class. Here the method readBook() has been over-ridden in
//the child class BigKid()
//Create a class Teenager which extends Kid created above (#14). Implement
// readBook() differently in Teenager class. In main method, declare 2 variables k1,
// k2 of type Kid.Create objects of type BigKid and Teenager such that K1 should
// reference object of class BigKid and K2 should reference object of class Teenager.
//Call their respective readBook() methods.The output is different from both the
//method calls even if the variable type is the same i.e.Kid.This is compile time
//polymorphism example.
    public  class Kid
    {
        public void ReadBook()
        {
            Console.WriteLine("Kid is reading book");

        }
        public  void ReadBook(int id,string name)
        {
            Console.WriteLine("Riya is reading book");
        }

    }
    public class Bigkid:Kid
    {
        public  void ReadBook()
        {
            Console.WriteLine("Bigkid is reading book");

        }
        public static void Main(string[] args)
        {
            Bigkid k = new Bigkid();
            Kid kid = new Kid();
            kid.ReadBook(101,"Riya");
            k.ReadBook();
            

        }
    }

}

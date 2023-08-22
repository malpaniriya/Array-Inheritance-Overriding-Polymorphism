using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixthProject.Overloading
{
    //WAP to create class company with method address.
    //create class eBay which extends company implement address() differently in eBay class.
    //Here the method address ()has been overridden in child class.
    public  class Company 
    {
        public virtual void Address()
        {
            Console.WriteLine("Thsi is parent class");
        }
    }
    public class Ebay: Company
    {
        public override void Address()
        {
            Console.WriteLine("This is child class");
        }
        public static void Main(string[] args)
        {
            Ebay e=new Ebay();
            e.Address();
        }
    }
}

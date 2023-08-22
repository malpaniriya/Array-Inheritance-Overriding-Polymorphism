using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixthProject.InheritanceAssignment
{//Create interface IceCream with method eat, and Juice with method drink.
 //Create class Mastani which implements both interfaces.
    public interface Icecream
    {
        void eat();

    }
    public interface Juice
    {
        void drink();
    }
  public  class Mastani: Icecream,Juice
    {
        public void eat()
        {
            Console.WriteLine("Eating Mastani Icecream");

        }
        public void drink()
        {
            Console.WriteLine("Drinking Mastani Icecream");

        }
        public static void Main(string[] args)
        {
            Icecream i=new Mastani();
            i.eat();
            Juice j=new Mastani();
            j.drink();


        }


    }
}

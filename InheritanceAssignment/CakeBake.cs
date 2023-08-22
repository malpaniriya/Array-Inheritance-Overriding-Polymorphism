using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixthProject.InheritanceAssignment
{
//Create interface Cake with a method declared as bake. Create 2 classes
//Strawberry, BlackForest both implementing Cake interface.
    public  interface ICake
    {
        void bake();

    }
     class Strawberry : ICake
    {
        public void bake()
        {
            Console.WriteLine("Class Strawberry");


        }
    }
    class Blackforest : ICake
    {
        public void bake()
        {
            Console.WriteLine("Class Blackforest");
        }
        public static void Main(string[] args)
        {
            ICake s= new Strawberry();
            ICake b=new Blackforest();
            s.bake();
            b.bake();

        }
    }
}

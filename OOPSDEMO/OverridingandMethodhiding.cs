using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixthProject.OOPSDEMO
{
    //lab assignment
    public class Laptop
    {
        protected int id;
        protected string name;

        public Laptop(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public virtual string Display()
        {
            return  $"Parent Class";
        }

    }
    public class Dell: Laptop
    {
        protected string color;
       
        public Dell(int id,string name,string color): base(id,name)
        {
            this.color = color;

        }
        public override string Display()
        {
            return $"Child Class";
        }

    }
}



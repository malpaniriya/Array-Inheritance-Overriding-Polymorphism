using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixthProject.Overloading
{
    //WAP to create class Bike with fields color ,speed and  method bikeInfo() which is show color and speed of bike .
    //create class Pulsar which extends Bike implement bikeInfo() differently child 
    public class Bike
    {
        protected string color;
        protected int speed;

        public virtual string Bikeinfo(string color, int speed)
        {
            return $"{color} , {speed}";
        }
    }
    public class Pulsur: Bike
    {
        public override string Bikeinfo(string color, int speed)
        {
            return $"{color} , {speed}";
        }

        public static void Main(string[] args)
        {
            Pulsur pulsur = new Pulsur();
            Console.WriteLine(pulsur.Bikeinfo("Black",200));
        }

    }
}

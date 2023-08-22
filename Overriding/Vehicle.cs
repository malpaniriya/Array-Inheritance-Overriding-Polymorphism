using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixthProject.Overloading
{
    //WAP to create class Vehicle with methods accelerate(long mph) with long type parameter ,stop(),run() all method return string type of value.
    //Create class car which extends Vehicle implement accelerate(long mph)differently in car class.
    public class Vehicle
    {
        public virtual void Accelerate()
        {
            Console.WriteLine("This is parent class");
        }
        public string Stop(long speed)
        {
            return $"speed";
        }
        public string Run(long speed)
        {
            return $"run";
        }

    }
    public class Car: Vehicle
    {
        public override void Accelerate()
        {
            Console.WriteLine("This is child class");
        }

        public static void Main(string[] args)
        {
            Car car = new Car();
            car.Accelerate();
            Console.WriteLine(car.Stop(101));
            Console.WriteLine(car.Run(200));

        }


    }
}

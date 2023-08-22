using SixthProject.Overloading;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SixthProject.Methods
{
    //add method displayData inside Student class change
//    values of id name in that method & also print the changed
//values in same method.Call displayData method from
//main method and see the output.Observe displayData can
//only be called by creating object of Student

    public class Studentttt
    {
        private int id;
        private string name;

        public Studentttt(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
        public void DisplayData()
        {
            id = 101;
            name = "Riya";
            Console.WriteLine($"{id},{name}");


        }
        public static void Main(string[] args)
        {
            Studentttt s = new Studentttt(102, "Rio");
            s.DisplayData();
            


        }
    }
}

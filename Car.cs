using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SixthProject
{
    //using default parameter
    public class Car
    {
        private string modelname, companyname;
        private int cost;

        public Car(string modelname, int cost, string companyname = "hundai")
        {
            this.modelname = modelname;
            this.companyname = companyname;
            this.cost = cost;
        }
        public void Accept(string modelname, string companyname = "Hundai")
        {

        }
        public string Print()
        {
            return $"{companyname} {modelname} {cost}";



        }
    }
}


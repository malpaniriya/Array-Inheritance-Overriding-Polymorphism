﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixthProject
{
    //Program based on method overloading
    public class Calculation
    {
        public int Addition(int a,int b)
        {
            return a + b;

        }

        public int Addition(int a,int b,int c)
        {
            return a+b+c;
        }

        public double Addition(int a,double b)
        {
            return a + b;
        }

        public double Addition(double a,double b)
        {
            return a + b;
        }
        
            }
}

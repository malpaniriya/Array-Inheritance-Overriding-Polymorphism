﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixthProject.OOPSDEMO
{
    //partial concept
    public partial class Calc
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Sub(int a, int b)
        {
            return a - b;
        }

        public int Multiply(int a, int b)
        {
            return (a * b);
        }

        partial void SquareRoot(int a);
    }
}



        

        
        

        
    


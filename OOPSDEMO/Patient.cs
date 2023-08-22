using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SixthProject.OOPSDEMO
{
    public class Person
    {
        protected string name;
        protected string address;
        protected long adharno;

        public  Person(string name,string address, long adharno)
        {
            this.name = name;
            this.address = address;
            this.adharno = adharno;
        }

       
        }
    public class Patient :Person
    {
        public string bloodgrp;
        public int bedno;
        
        public Patient (int  bedno, string bloodgrp,string name, string address, long adharno) : base (name,address,adharno)
        {
            this.bloodgrp= bloodgrp;
            this.bedno = bedno;
            
         
        }
        public void show()
        {
            Console.WriteLine(bedno +name+address+adharno+bloodgrp);
        }



    }

    }


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixthProject
//1)add method displayData inside Student class change
////values of id name in that method & also print the changed
////values in same method.Call displayData method from
////main method and see the output.Observe displayData can
////only be called by creating object of Student


{
    public class Student2
    {
        private int id;
        private string name;

        public Student2(int id,string name)//constructor
        {
            this.id = id;
            this.name = name;

        }
        public string Accept()
        {
            id = 101;
            name = "Riya";


          
            return $"{id},{name}";

        }
    
        

        }
    }


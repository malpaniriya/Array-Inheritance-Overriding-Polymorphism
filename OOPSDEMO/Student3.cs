using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixthProject.OOPSDEMO
{
    // 2)Create getId() method in Student class. call getId() method
    //from displayData method so that you know that one
    //method can be called from another method.Return id
    //from getId() method and set that id to the instance
    //variable in displayData method.

    public class Student3
    {
        private int id;
        private string name;

       public int GetId()
        {
            return 10;

        }
        public void DisplayData()
        {
            this.id= this.GetId();
            Console.WriteLine(id);

        }
        

       


        }
    }


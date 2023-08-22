using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SixthProject.OOPSDEMO.Interface;

namespace SixthProject.OOPSDEMO
{
    //inteface lab program
  
    
        public interface IDress
        {
            string Display();
        }

        public interface IOrder
        {
            string Display();
        }
        public class Transactions : IDress, IOrder
        {
           
                string IDress.Display()
                {
                    return "Dress Details";
                }

                string IOrder.Display()
                {
                    return "Order Details";
                }
            }
        }
    



    


  
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SixthProject
{
    public class Movie
    {
        private int id, numberoftickets = 20, totalcost, num, price;
        private string name, type;


        public Movie(int id,string name)
        {
            this.id = id;
            this.name = name;   
        }
        public string Display()
        {
            return $"Movie id= {id},Movie name={name},type={type},numberoftickets= {numberoftickets},price={price}totalcost={totalcost}";

        }
        public void findAvailableTickets()
        {
            Console.WriteLine("Enter no. of tickets to book");
            num = Convert.ToInt32(Console.ReadLine());
            if (numberoftickets>num)
            {
                numberoftickets = numberoftickets - num;
                this.CalculateTicketCost();

            }
            else
            {
                Console.WriteLine("Insufficient tickets");
            }
        }
        public void CalculateTicketCost()
        {
            Console.WriteLine("1 silver=100\n 2 Gold=200\n Platinum=300\n");
            Console.WriteLine("Enter Type");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    type = "silver";
                    price = 100;
                    break;

                case 2:
                    type = "gold";
                    price = 200;
                    break;
                case 3:
                    type = "platinum";
                    price = 300;
                    break;
            }

            totalcost = num * price;
        }
        public void Details()
        {
            Console.WriteLine($"Movie name={name} movie type={type} No of Tickets={numberoftickets} Total cost={totalcost}");
        }
    }
            
            
            
               

        



            


        }
        
        


                    

                
        


       


        
       





    


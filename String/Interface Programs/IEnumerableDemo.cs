using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace String.Interface_Programs
{
    internal class IEnumerableDemo
    {
        public class Player
        {
            private int runs;
            private string name;

            public Player(int runs, string name)
            {
                this.runs = runs;
                this.name = name;

            }
            public override string ToString()
            {
                return $"{runs} -> {name}";
            }
        }

        public class Team : IEnumerable
        {
            private Player[] Players;

            public Team()
            { 
                Players = new Player[3]
              
                {
                    new Player(5000, "Sachin"),
                    new Player(4000, "Virat"),
                    new Player(3000,"Rohit")


                };
            }
            public IEnumerator GetEnumerator()
            {
                return Players.GetEnumerator();
            }
        }

        public class Program
        {
            public static void Main(string[] args)
            {
                Team team = new Team();

                foreach (Player item in team)
                {
                    Console.WriteLine(item);
                }

            }
            
        }

    }
}

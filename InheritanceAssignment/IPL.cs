using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixthProject.InheritanceAssignment
{
    public class IPL
    {
        public void play()
        {
            Console.WriteLine("IPL Team is Playing");
        }
    }
    public class RCB: IPL
    {
        public RCB()
        {

        }
       


    }
    public class CSK: IPL
    {
        public CSK()
        {

        }
        public static void Main(string[] args)
        {
            RCB r1= new RCB();
            r1.play();
            CSK c1= new CSK();
            c1.play();
        }

    }
    
        
        

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixthProject.OOPSDEMO
{
    public interface IPrintable
    {
        string Print();

    }
    public class User : IPrintable
    {
        public string Print()
        {
            return Print();
            {
                return "User Details";
            }
        }

    }
}


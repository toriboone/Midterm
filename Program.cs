using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm2
{
    class Program
    {
        static void Main(string[] args)
        {

            bool keepGoing = true;
            
            while (keepGoing)
            {
                //List<Scroll> scrolls = new List<Scroll>();
                
                keepGoing = Library.FirstMenu();
            }
        }
    }
}
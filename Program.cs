using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Salve Bibliotheca Alexdriae");
            bool keepGoing = true;

            while (keepGoing)
            {
                //List<Scroll> scrolls = new List<Scroll>();

                keepGoing = Library.FirstMenu();
            }
        }
    }
}
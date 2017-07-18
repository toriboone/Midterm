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
            Console.WriteLine("Salve Bibliotheca Alexdriae"); //yay Latin!
            bool keepGoing = true; 

            while (keepGoing) //this assures that all actions return back to the main menu
            {
                keepGoing = Library.FirstMenu(); //menu item 4 = false
            }
        }
    }
}
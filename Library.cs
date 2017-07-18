using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm
{
    static class Library
    {
        static public List<Scroll> scrolls = CreateLibraryList(); //declares the object for the class

        static public List<Scroll> CreateLibraryList() //builds the object
        {
            scrolls = new List<Scroll>(); //only makes one cookie

            scrolls.Add(new Scroll("The Odyssey", "Homer", "poetry", true));
            scrolls.Add(new Scroll("Ode to Aphrodite", "Sappho", "poetry", true));
            scrolls.Add(new Scroll("Ode to Hieron of Syracuse", "Bacchylides", "poetry", true));
            scrolls.Add(new Scroll("Myrmidons", "Aeschylus", "drama", true));
            scrolls.Add(new Scroll("Peliades", "Euripides", "drama", true));
            scrolls.Add(new Scroll("Clouds", "Aristophanes", "drama", true));
            scrolls.Add(new Scroll("Epitaph for Zeno of Citium", "Zenodotus", "criticism", true));
            scrolls.Add(new Scroll("Scholia of The Illiad", "Aristarchus", "criticism", true));
            scrolls.Add(new Scroll("On Ungrammatical Words", "Aristonicus", "criticism", true));
            scrolls.Add(new Scroll("Phaedrus", "Plato", "philosophy", true));
            scrolls.Add(new Scroll("On Nature", "Heraclitus", "philosophy", true));
            scrolls.Add(new Scroll("Politics", "Aristotle", "philosophy", true));
            scrolls.Add(new Scroll("The Histories", "Herodotus", "history", true));
            scrolls.Add(new Scroll("History of the Peloponnesian War", "Thucydides", "history", true));
            scrolls.Add(new Scroll("Hellenica", "Xenophon", "history", true));
            scrolls.Add(new Scroll("Disappearances of the Sun", "Eudoxus", "science", true));
            scrolls.Add(new Scroll("Indica", "Megasthenes", "science", true));
            scrolls.Add(new Scroll("Almagest", "Ptolemy", "science", true));
            scrolls.Add(new Scroll("Measurement of a Circle", "Archimedes", "mathematics", true));
            scrolls.Add(new Scroll("Geometry", "Pythagoras", "mathematics", true));
            scrolls.Add(new Scroll("The Astronomical Canon", "Hypatia", "mathematics", true));
            scrolls.Add(new Scroll("Prognosis", "Hippocrates", "medicine", true));
            scrolls.Add(new Scroll("On Pulses", "Herophilus", "medicine", true));
            scrolls.Add(new Scroll("On the Diet of Seafarers", "Rufus", "medicine", true));

            return scrolls;
        }

        static public bool Check(string userInput, int which) //used on both menus to check for valid input per menu
        {
            bool trueCheck = false;
            if (userInput == "1" || userInput == "2" || userInput == "3" || userInput == "4" && which == 1 )
            {
                trueCheck = true;
            }
            else
            {
                trueCheck = false;
            }
            if (userInput == "y" || userInput == "n" && which == 2)
            {
                trueCheck = true;
            }
            return trueCheck;

        }
        static public bool FirstMenu()
        {
            Console.WriteLine();
            Console.WriteLine("Would you like to: \n(1)Check out a scroll \n(2)Return a scroll \n(3)Browse the collection \n(4)Burn the library down?");
            string tat;
            bool valid = false;
            bool continuing = false;

            tat = Console.ReadLine();

            valid = Check(tat, 1); //runs back to validation method 
            while (!valid)
            {
                Console.WriteLine("Try: \n(1)For checking out a scroll \n(2)For returning a scroll \n(3)For viewing the entire library \n(4)To quit");
                tat = Console.ReadLine();
                valid = Check(tat, 1); //keeps going back to the validation method 
            }

            if (tat == "1")
            {
                //Console.WriteLine("Would you like to search by (1)Title, (2)Author, or (3)Topic? Please enter a number.");
                
                //valid = Check(input, 1);
                //while (valid == false)
                //{
                //    Console.WriteLine("Try 1 for searching by title, 2 for searching by author, 3 for searching by topic.");
                //    input = Console.ReadLine();
                //    valid = Check(input, 1);
                //}

                Console.WriteLine("Please search by title, author, or topic.");
                string search = Console.ReadLine();
                bool cont = false;
                //string dayDate = DueDate();
                string yn = "n";

                foreach (Scroll b in scrolls)
                {

                    //if (input == "1" && b.title == search) //Does the search really need to be split per string in the object?
                    if (b.title == search || b.author == search || b.topic == search)
                    {

                        if (b.checkedin == true) //Couldn't this whole statement be put into a method and ran for each type of search?
                        {
                            Console.WriteLine(b.title + " by " + b.author + " is currently available.");
                            Console.WriteLine("Would you like to check this scroll out? y/n");
                            yn = Console.ReadLine();

                            cont = Check(yn, 2);
                            if (cont == false) //keeps user stuck here until valid input
                            {
                                Console.WriteLine("Please try again.");
                                yn = Console.ReadLine();
                                cont = Check(yn, 2);
                            }
                            if (yn == "y")
                            {
                                Console.WriteLine("You have successfully checked this scroll out.");
                                Console.WriteLine("It is due back on " + DueDate() + ".  Thank you!");
                                b.checkedin = false;
                            }
                        }
                        else if (b.checkedin == false)
                        {
                            Console.WriteLine("Sorry, " + b.title + " by " + b.author + " is currently unavailable.");
                            Console.WriteLine("It is estimated to be available by " + DueDate() + ".");
                        }
                    }
                    //else if (input == "2" && b.author == search)
                    //{
                    //    Console.WriteLine(b.title + " by " + b.author);
                    //}
                    //else if (input == "3" && b.topic == search)
                    //{
                    //    Console.WriteLine(b.title + " by " + b.author);
                    //}
                    continuing = true;
                }
            }
            if (tat == "2")
            {
                Console.WriteLine("Please enter the title or author of the scroll you wish to return:");
                string search = Console.ReadLine();
                foreach (Scroll c in scrolls)
                {
                    if (c.title == search || c.author == search)
                    {
                        if (c.checkedin == false)
                        {
                            Console.WriteLine("Thank you for returning " + c.title + " by " + c.author + ".");
                            c.checkedin = true; //true = checked in, false = checked out
                        }
                        else if (c.checkedin == true)
                        {
                            Console.WriteLine("This scroll is available.");
                        }
                    }
                    continuing = true; //brings user back to main menu
                }
            }

            if (tat == "3") //browseable list
            {
                foreach (Scroll a in scrolls)
                {
                    Console.WriteLine(a.title + " by " + a.author + "; " + a.topic);
                }
                continuing = true;
                return continuing;
            }
            if (tat == "4")
            {
                Console.WriteLine("You burned down the library. You monster!");
                continuing = false;
                return continuing; //does NOT take user back to menu
            }
            return continuing;
        }
        
        public static string DueDate()
        {
            DateTime thisday = DateTime.Now;
            DateTime duedate = DateTime.Now.Date.AddDays(14);
            return duedate.ToString("D");
        }
    }

}

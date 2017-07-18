﻿using Midterm2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm2
{
   static class Library
    {
        //static public Status s = new Status();
        static public List<Scroll> scrolls = CreateLibraryList();

        static public List<Scroll> CreateLibraryList()  
        {
            scrolls = new List<Scroll>();



            scrolls.Add(new Scroll("The Odyssey", "Homer", "poetry", true));
            scrolls.Add(new Scroll("Ode to Aphrodite", "Sappho", "poetry", true));
            scrolls.Add(new Scroll("Ode to Hieron of Syracuse", "Bacchylides", "poetry", true));
            scrolls.Add(new Scroll("Myrmidons", "Aeschylus", "drama", true));
            scrolls.Add(new Scroll("Peliades", "Euripides", "drama", true));
            scrolls.Add(new Scroll("Clouds", "Aristophanes", "drama", true));
            scrolls.Add(new Scroll("Epitaph for Zeno of Citium", "Zenodotus", "criticism", true));
            scrolls.Add(new Scroll("Scholia of The Illiad", "Aristophanes", "criticism", true));
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


        //static public List<Status> checkedOutItems = new List<Status>();

        static public bool Check(string userInput, int which)
        {
            bool trueCheck = false;
            if (userInput == "1" || userInput == "2" || userInput == "3" && which == 1)
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
            Console.WriteLine("Welcome to the Library of Alexandria");
            Console.WriteLine("Would you like to (1)search for a scroll or (2)view entire inventory or (3) burn the library down?");
            string tat = " ";
            bool valid = false;
            bool continuing = false;

            tat = Console.ReadLine();
            

            valid = Check(tat, 1);
            while (!valid)
            {
                Console.WriteLine("Try a 1 for searching for a scroll, 2 for viewing the entire library, or 3 to quit.");
                tat = Console.ReadLine();
                valid = Check(tat, 1);
            }


            if (tat == "1")
            {
                Console.WriteLine("Would you like to search by title, author, topic? 1 for title, 2 for author, 3 for topic.");
                string input = Console.ReadLine();
                valid = Check(input, 1);
                while (valid == false)
                {
                    Console.WriteLine("Try a 1 for searching by title, 2 for searching by author, 3 for searching by topic.");
                    input = Console.ReadLine();
                    valid = Check(input, 1);
                }


                Console.WriteLine("Please enter precisely what you are searching for.");
                string search = Console.ReadLine();
                bool cont = false;
                string dayDate = DueDate();
                string yn = "n";

                foreach (Scroll b in scrolls)
                {

                    if (input == "1" && b.title == search)
                    {
                        
                        if (b.checkedin == true)
                        {
                            Console.WriteLine(b.title + " by " + b.author + " is currently available");
                            Console.WriteLine("Would you like to check this title out?");
                            yn = Console.ReadLine();
                            
                            cont = Check(yn, 2);
                                if (cont == false)
                            {

                                Console.WriteLine("Try again, y or an n to checkout");
                                yn = Console.ReadLine();
                                cont = Check(yn, 2);
                            }
                                if (yn == "y")
                            {
                                Console.WriteLine("You have successfully checked this scroll out");
                                Console.WriteLine("It is due back on Aug 1st, 2017.  Thank you!");
                                b.checkedin = false;
                            }
                          
                        } else if (b.checkedin == false)
                        {
                            Console.WriteLine(b.title + " by " + b.author + " is currently unavailable");
                        }

             
                    }
                    else if (input == "2" && b.author == search)
                    {
                        Console.WriteLine(b.title + " by " + b.author);
               
                      
                    }
                    else if (input == "3" && b.topic == search)
                    {
                        Console.WriteLine(b.title + " by " + b.author);
                 
                   
                    }
                    continuing = true;
                }
            }

            if (tat == "2")
            {
                foreach (Scroll a in scrolls)
                {
                    Console.WriteLine(a.title + " by " + a.author + "; " + a.topic);
                }
                continuing = true;
                return continuing;
            }
            if (tat == "3")
            {
                Console.WriteLine("You burned down the library.");
                continuing = false;
                return continuing;
            }
            return continuing;

        }public static string DueDate()
        {
            DateTime thisday = DateTime.Now;
            DateTime duedate = DateTime.Now.Date.AddDays(14);

            return  duedate.ToString();
        }


    }

}






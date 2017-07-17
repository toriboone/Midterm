using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm
{
    class Library
    {
        List<Scroll> scrolls;
        public Library()
        {
            scrolls = new List<Scroll>();
            LibraryInventory();
        }
        public void LibraryInventory()
        {
            scrolls.Add(new Scroll("The Odyssey", "Homer", "poetry"));
            scrolls.Add(new Scroll("Ode to Aphrodite", "Sappho", "poetry"));
            scrolls.Add(new Scroll("Ode to Hieron of Syracuse", "Bacchylides", "poetry"));
            scrolls.Add(new Scroll("Myrmidons", "Aeschylus", "drama"));
            scrolls.Add(new Scroll("Peliades", "Euripides", "drama"));
            scrolls.Add(new Scroll("Clouds", "Aristophanes", "drama"));
            scrolls.Add(new Scroll("Epitaph for Zeno of Citium", "Zenodotus", "criticism"));
            scrolls.Add(new Scroll("Scholia of The Illiad", "Aristophanes", "criticism"));
            scrolls.Add(new Scroll("On Ungrammatical Words", "Aristonicus", "criticism"));
            scrolls.Add(new Scroll("Phaedrus", "Plato", "philosophy"));
            scrolls.Add(new Scroll("On Nature", "Heraclitus", "philosophy"));
            scrolls.Add(new Scroll("Politics", "Aristotle", "philosophy"));
            scrolls.Add(new Scroll("The Histories", "Herodotus", "history"));
            scrolls.Add(new Scroll("History of the Peloponnesian War", "Thucydides", "history"));
            scrolls.Add(new Scroll("Hellenica", "Xenophon", "history"));
            scrolls.Add(new Scroll("Disappearances of the Sun", "Eudoxus", "science"));
            scrolls.Add(new Scroll("Indica", "Megasthenes", "science"));
            scrolls.Add(new Scroll("Almagest", "Ptolemy", "science"));
            scrolls.Add(new Scroll("Measurement of a Circle", "Archimedes", "mathematics"));
            scrolls.Add(new Scroll("Geometry", "Pythagoras", "mathematics"));
            scrolls.Add(new Scroll("The Astronomical Canon", "Hypatia", "mathematics"));
            scrolls.Add(new Scroll("Prognosis", "Hippocrates", "medicine"));
            scrolls.Add(new Scroll("On Pulses", "Herophilus", "medicine"));
            scrolls.Add(new Scroll("On the Diet of Seafarers", "Rufus", "medicine"));
        }
        public void FirstMenu()
        {
            Console.WriteLine("Welcome to the Library of Alexandria");
            Console.WriteLine("Would you like to (1)search for a scroll or (2)view entire inventory?");
            int input = int.Parse(Console.ReadLine());

            if (input == 1)
            {
                Console.WriteLine("What do you want to search by? Title, Author, or Topic?");
                string tat = Console.ReadLine();
                tat = tat.ToLower();
                string search = Console.ReadLine();
                bool foundSomething = false;
             
                foreach (Scroll b in scrolls)
                {
                    
                    if (tat == "title" && b.title == search)
                    {
                        Console.WriteLine(b.title + " by " + b.author);
                        foundSomething = true;
                    }
                    else if (tat == "author" && b.author == search)
                    {
                        Console.WriteLine(b.title + " by " + b.author);
                        foundSomething = true;
                    }
                    else if (tat == "topic" && b.topic == search)
                    {
                        Console.WriteLine(b.title + " by " + b.author);
                        foundSomething = true;
                    }
                }
                if (foundSomething == false)
                {
                    Console.WriteLine("Invalid input. Please try again.");
                }
            }
            else if (input == 2)
            {
                foreach (Scroll a in scrolls)
                {
                    Console.WriteLine(a.title + " by " + a.author + "; " + a.topic);
                }
            }
            else
            {
                Console.WriteLine("Please choose an option.");
            }
        }
    }
}

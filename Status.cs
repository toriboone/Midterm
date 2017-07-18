using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace Midterm2
//{
//    public class Status
//    {
//        bool scrollStatus = true;
//        public string title;
//        public string dueDate;

       //public Status(string title, string dueDate)
       //{
       //     this.title = title; // need to grab the title from the library lst and search
       //     this.dueDate = dueDate; //this needs to be added to the original index and put into the new list
       // }

//        public string StatusOut()  // come back here to change this to string
//        {
//            var status = Library.scrolls.FirstOrDefault((Status i) => i.title == title);

//            if (scrollStatus == false && status == null) //scroll is in the library, can be checked out
//            { //if scrollStatus  = true the book is not in the library
//                Library.scrolls.Add(this);
//                return "This scroll has been checked out.";
//            }
//            else if (scrollStatus == true || status != null) //scroll is not in the library, cannot be checked out
//            {

//                Console.WriteLine("Not free for not available.");
//                return "This scroll is not available to be c "; //come back

//            }
//        }
//        public void StatusIn()//come back here to change this to string
//        {
//            var status = Library.scrolls.FirstOrDefault((Status i) => i.title == title);

//            if (scrollStatus == true && status != null) //scroll is in the library, can be checked out
//            { //if scrollStatus  = true the book is not in the library
//                Library.checkedOutItems.Remove(this);
//            }
//            else if (scrollStatus == false || status == null) //scroll is not in the library, cannot be checked out
//            {
//                Console.WriteLine("Back in stacks.");

//            }
//        }
//    }

//    }

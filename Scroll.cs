using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm
{
    class Scroll
    {
        //public string duedate = "0";
        public bool checkedin;
        public string author;
        public string topic;
        public string title;

        public Scroll(string title, string author, string topic, bool checkedin)
        {

            this.checkedin = checkedin;
            this.title = title;
            this.author = author;
            this.topic = topic;
        }
    }
}
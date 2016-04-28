using System;

namespace SharedCode
{
    public class Book
    {
        public int ID { get; set; }
        public String Name { get; set; }
        public String Author { get; set; }

        public String Editor { get; set; }

        public int Year { get; set; }

        public override string ToString()
        {
            return String.Format("{0} - {1} - {2} - {3}", this.Name, this.Author, this.Editor, this.Year);
        }
    }
}


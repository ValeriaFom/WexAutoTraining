using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5_ClassBook_Homework9_BookCatalog
{
    public class Book
    {
        public string Name { get; set; }
        public int NumberOfPages { get; set; }
        public int ID { get; set; }

        public DateTime DateOfPublication { get; set; }

        public List<Author> Authors;        

        public override string ToString()
        {
            return Name + ", " + DateOfPublication + ", " + ID;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5_ClassBook_Homework9_BookCatalog
{
    public class Book
    {
        public string Name { get; }
        public int NumberOfPages { get; }
        public int ID { get; }

        public DateTime DateOfPublication { get; }

        public List<Author> Authors;        

        public Book (string name, List<Author> author, DateTime dateOfPublication, int nbrofPages, int id)
        {
            Name = name;
            Authors = author;            
            DateOfPublication = dateOfPublication;
            NumberOfPages = nbrofPages;
            ID = id;            
        }        

        public override string ToString()
        {
            return Name + ", " + DateOfPublication + ", " + ID;
        }
    }
}

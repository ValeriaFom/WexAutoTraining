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

        public Book(string name, List<Author> author, DateTime dateOfPublication, int nbrofPages, int id)
        {
           
                Name = name;
                DateOfPublication = dateOfPublication;
                NumberOfPages = nbrofPages;
                ID = id;
                Authors = author;

                //authors = new List<Author>(author);  ///????????
                //authors.Add(author);

                //author = Books.SelectMany(x => x.Authors);
        }
    }
}
    


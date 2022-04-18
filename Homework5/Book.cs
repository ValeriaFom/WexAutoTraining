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

        //private int id;
        public int ID { get; }

        //public int ID
        //{
        //    get
        //    {
        //        return id;
        //    }
        //    set
        //    {
        //        foreach (var book in Catalog.Books ?)
        //        {
        //            if (value != book.ID)
        //            {
        //                id = value;
        //            }
        //            else
        //            {
        //                Console.WriteLine("A book with the entered ID already exists! Please, add another book.");
        //                break;
        //            }
        //        }
        //    }
        //}

        public DateTime DateOfPublication { get; }

        public List<Author> Authors;        

        public Book (string name, List<Author> author, DateTime dateOfPublication, int nbrofPages, int id)  //как сделать возможность добавления нескольких авторов?
        {
            Name = name;
            Authors = author;            
            DateOfPublication = dateOfPublication;
            NumberOfPages = nbrofPages;
            ID = id;            
        }
        //public static string ToStringBook()
        //{
        //    return Name + ", " + Author.ToStringAuthor() + ", " + DateOfPublication + ", " + ID;  ///???
        //}

        public override string ToString()
        {
            return Name + ", "+ DateOfPublication + ", " + ID;
            //return Name + ", " + Author.FirstName + ", " + DateOfPublication + ", " + ID;  ///????????????
            //return Name + ", " + Author.ToString() + DateOfPublication + ", " + ID;
        }
    }
}

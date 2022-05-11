using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5_ClassBook_Homework9_BookCatalog
{
    public class Catalog: IEnumerable<Book>
    {
        static List<Book> _books;
        private static List<Book> Books
        {
            get => _books;
        }
        public Catalog()
        {
            _books = new List<Book>();
        }

        public IEnumerator<Book> GetEnumerator()
        {
            return Books.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        //1
        public List<Book> GetBooksSortedByName()
        {
            var sortedBooks = Books.OrderBy(x => x.Name).ToList();
            return sortedBooks;   
        }

        ////2
        //public List<Author> GetAuthorsFromCatalog()
        //{
        //    return Books.SelectMany(x => x.Authors).Distinct(new AuthorsEqualityComparer()).ToList();
        //}

        ////3
        //public List<Book> GetBooksByAuthor(string firstName, string lastName)
        //{
        //    return Books.Where(b => b.Authors.Where(x => x.FirstName == firstName && x.LastName == lastName).Count() !=0).ToList();
        //}

        //public List<Book> GetBooksOfAuthorPublichedAfterData(string lastName, string firstName, DateTime date)
        //{
        //    var books = new List<Book>();
        //    foreach (var book in Books)
        //    {
        //        if (book.DateOfPublication >= date && book.Authors.Any(b => b.LastName == lastName && b.FirstName == firstName))
        //        {
        //            books.Add(book);
        //        }
        //    }
        //    return books;
        //}

        ////4
        //public List<Author> GetAuthorsSortedByDateOfBirth()
        //{
        //    var authors = Books.SelectMany(x => x.Authors).OrderBy(b => b.DateofBirth).Distinct().ToList();
        //    return authors;
        //}

        //HW10
        /// <summary>
        /// Book's ID should be unique.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>True if ID is unique.</returns>
        public static bool IsIDUnique(int id)
        {
            foreach (var book in Books)
            {
                if (id == book.ID) 
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Exeptions:
        /// - "A book with the entered ID already exists! Please, add another book.";
        /// </summary>
        /// <param name="name"></param>
        /// <param name="author"></param>
        /// <param name="dateOfPublication"></param>
        /// <param name="nbrofPages"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public Book AddBook(string name, List<Author> author, DateTime dateOfPublication, int nbrofPages, int id)
        {
            var newBook = new Book();
            var authors = new List<Author>();

            if (IsIDUnique(id) == true)
            {
                Books.Add(newBook);
                newBook.Name = name;
                newBook.DateOfPublication = dateOfPublication;
                newBook.NumberOfPages = nbrofPages;
                newBook.ID = id;
                authors = author;

                //authors = new List<Author>(author);  ///????????
                //authors.Add(author);

                //author = Books.SelectMany(x => x.Authors);

                return newBook;
            }
            else
            {
                throw new Exception("A book with the entered ID already exists! Please, add another book.");
            }          
        }
    }
}

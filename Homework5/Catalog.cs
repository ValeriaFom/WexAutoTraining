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
        List<Book> _books;
        public List<Book> Books
        {
            get
            {
                return _books;
            }
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

        //2
        public List<Author> GetAuthorsFromCatalog()
        {
            return Books.SelectMany(x => x.Authors).Distinct().ToList();
        }

        //3
        public List<Book> GetBooksByAuthor(string firstName, string lastName)
        {
            return Books.Where(b => b.Authors.Where(x => x.FirstName == firstName && x.LastName == lastName).Count() !=0).ToList();
        }

        public List<Book> GetBooksOfAuthorPublichedAfterData(string lastName, string firstName, DateTime date)
        {
            List<Book> books = new List<Book>();
            foreach (var book in Books)
            {
                if (book.DateOfPublication >= date && book.Authors.Any(b => b.LastName == lastName && b.FirstName == firstName))
                {
                    books.Add(book);
                }
            }
            return books;
        }

        //4
        public List<Author> GetAuthorsSortedByDateOfBirth()
        {
            var authors = Books.SelectMany(x => x.Authors).OrderBy(b => b.DateofBirth).Distinct().ToList();
            return authors;
        }        
    }
}

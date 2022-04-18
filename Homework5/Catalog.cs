using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5_ClassBook_Homework9_BookCatalog
{
    public class Catalog: IEnumerable<Book> //не делается public ??
    {
        List<Book> _books;
        public List<Book> Books //зачем 2 раза используем лист? _books и Books
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
            return Books.SelectMany(x => x.Authors).Distinct().ToList();  //нужно создать comparer
        }

        //3

        public List<Book> GetBooksByAuthor2(string firstName, string lastName)
        {
            //List<Book> books = new List<Book>();
            return Books.Where(b => b.Authors.Where(x => x.LastName == lastName && x.FirstName == firstName).Count() !=0).ToList();

            //foreach (var book in resultAuthors)
            //{
            //    books.Add(book);
            //}
            //return books;
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

        //var employees = from p in people
        //                join c in companies on p.Company equals c.Title
        //                select new { Name = p.Name, Company = c.Title, Language = c.Language };

        //foreach (var emp in employees)
        //    Console.WriteLine($"{emp.Name} - {emp.Company} ({emp.Language})");

        //4
        //public List<Author> GetAuthorsSortedByDateOfBirth2()
        //{
        //    var authors = Books.Authors.OrderBy(x => x.DateofBirth).ToList();   //????????????? non-static
        //    return authors;
        //}

        public List<Author> GetAuthorsSortedByDateOfBirth()
        {
            var authors = Books.SelectMany(x => x.Authors).OrderBy(b => b.DateofBirth).ToList();
            return authors;
        }        
    }
}

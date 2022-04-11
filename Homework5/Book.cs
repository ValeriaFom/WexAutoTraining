using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5_ClassBook
{
    class Book
    {
        public string Name { get; set; }
        public int NumberOfPages { get; set; }

        private int id;
        public int ID
        {
            get
            {
                return id;
            }
            set
            {
                foreach (var book in Catalog._bookCatalog)
                {
                    if (Catalog._bookCatalog.Count = 0)
                    {
                        id = value;
                    }
                    else if (value != book.ID)
                    {
                        id = value;
                    }
                    else
                    {
                        Console.WriteLine("A book with entered ID already exists! Please, add another book.");
                        break;
                    }
                }
            }
        }

        public DateTime DateOfPublication { get; set; }

        public List<Author> _bookAuthors;

        public Book (string name, Author author, DateTime dateOfPublication, int nbrofPages, int id)  //как сделать возможность добавления нескольких авторов?
        {
            name = Name;
            _bookAuthors.Add(author);
            dateOfPublication = DateOfPublication;
            nbrofPages = NumberOfPages;
            id = ID;
        }

        
        //List<Employee> _employees;
        //public List<Employee> Employees //зачем 2 раза используем лист? _employees и Employees
        //{
        //    get
        //    {
        //        return _employees;
        //    }
        //}

        //public Office()
        //{
        //    _employees = new List<Employee>();
        //}
    }
}

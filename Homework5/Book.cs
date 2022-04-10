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
        public int NumberOfPages;
        public int ID;
        public string dateOfPublication;

        public List<Author> _authors;

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

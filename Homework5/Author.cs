using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5_ClassBook_Homework9_BookCatalog
{
    public class Author
    {
        public string FirstName { get; }
        public string LastName { get; }
        public DateTime DateofBirth { get; }     
        
        public Author (string fname, string lname, DateTime dob)
        {
            FirstName = fname;
            LastName = lname;
            DateofBirth = dob;            
        }

        public override string ToString()
        {
            return FirstName + " " + LastName + ", " + DateofBirth;
        }

        public override bool Equals(object obj)
        {
            if (obj is Author)
            {
                Author author = obj as Author;
                return FirstName == author.FirstName && LastName == author.LastName;
            }
            return false;
        }
    }
}

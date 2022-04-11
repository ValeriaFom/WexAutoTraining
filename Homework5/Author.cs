using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5_ClassBook
{
    class Author
    {
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
        public DateTime DateofBirth { get; set; }     
        
        public Author (string fname, string lname, DateTime dob)
        {
            fname = FirstName;
            lname = LastName;
            dob = DateofBirth;            
        }
    }
}

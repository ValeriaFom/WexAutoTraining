﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5_ClassBook_Homework9_BookCatalog
{
    public class AuthorsEqualityComparer : IEqualityComparer<Author>
    {
        public bool Equals (Author x, Author y)
        {
            throw new NotImplementedException();
        }

        public int GetHashCode(Author obj)
        {
            throw new NotImplementedException();
        }
    }
}

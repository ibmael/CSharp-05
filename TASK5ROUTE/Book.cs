using System;
using System.Collections.Generic;
using System.Text;

namespace TASK5ROUTE
{
    internal class Books
    {
        public enum Genre
        {
            Fiction,
            NonFiction,
            Science
        }

        public class Book
        {
            private string password = "secret";
            internal int copiesInStock = 5;
            public string Title;
            public Genre Genre;
        }
    }
}

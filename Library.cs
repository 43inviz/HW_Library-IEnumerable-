using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace HW_Library
{
    internal class Library : IEnumerable
    {
        public string LibName { get; set; }
        public string Address {  get; set; }
        public Book[] BookList { get; set; }

        public Library() { }

        public Library(string libName, string address, Book[] books)
        {
            LibName = libName;
            Address = address;
            BookList = books;
        }

        public IEnumerator GetEnumerator()
        {
            foreach (Book book in BookList)
            {
                yield return book;
            }
        }

        
    }
}

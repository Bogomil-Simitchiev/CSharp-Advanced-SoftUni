using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace IteratorsAndComparators
{
    public class Library : IEnumerable<Book>
    {
        public List<Book> books;
        public Library(params Book[] books)
        {
            this.books = new List<Book>(books);
        }
        public IEnumerator<Book> GetEnumerator()
        {
            return new LibraryIterator(this.books);
        }

        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();

    }

    public class LibraryIterator : IEnumerator<Book>
    {
        private readonly List<Book> books;
        private int currentIndex;
        public LibraryIterator(List<Book> books)
        {
            this.Reset();
            this.books = new List<Book>(books);
        }
        public void Dispose() { }
        public bool MoveNext() => ++this.currentIndex < this.books.Count;
        public void Reset() => this.currentIndex = -1;
        public Book Current => this.books[this.currentIndex];
        object IEnumerator.Current => this.Current;

    }
}

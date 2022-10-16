//1. Create a class called Books with BookName and AuthorName members. Instantiate the class through constructor and also write a method Display() to display the details. Create an Indexer of Books Object to store 5 books in a class called BookShelf. Using the indexer method assign values to the books and display the same.

//(Hint : Use Composition. Books object inside BookShelf class)

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    class BookShelf
    {
        Books b;
        public static void SetIndexer(Books b)
        {
            b[0] = "ABC";
            b[1] = "DEF";
            b[2] = "GHI";
            b[3] = "JKL";
            b[4] = "MNO";

            b[0L] = "abc";
            b[1L] = "def";
            b[2L] = "ghi";
            b[3L] = "jkl";
            b[4L] = "mno";
            b.Display();
        }
        public BookShelf()
        {
            b = new Books();
            SetIndexer(b);
        }
    }
    class Books
    {
        string[] BookName = new string[5];
        string[] AuthorName = new string[5];
        public string this[int Bname]
        {
            get { return BookName[Bname]; }
            set { BookName[Bname] = value; }
        }
        public string this[long Aname]
        {
            get { return AuthorName[Aname]; }
            set { AuthorName[Aname] = value; }
        }
        public void Display()
        {
            Console.WriteLine("---BookS_Details---");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("The author of {0} is {1} ", BookName[i], AuthorName[i]);
            }
        }
    }
    class Driven_Bookshelf
    {
        public static void Main(string[] args)
        {
            BookShelf i = new BookShelf();
            Console.Read();
        }
    }
}
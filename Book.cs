using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe
{
    class Book
    {
        public string title;
        public string author;
        public int pages;

        //Constructor, 생성자
        public Book()
        {
            Console.WriteLine("Book");
        }

        public Book(string aTitle, string aAuthor, int aPages)
        {
            title = aTitle; // == book1.title = "Harry Potter";
            author = aAuthor;
            pages = aPages;
        }
    }
}

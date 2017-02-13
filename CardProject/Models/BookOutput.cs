using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardProject.Models
{
    internal static class BookOutput
    {
        public static void ConsoleOutput(List<Book> books)
        {

            Console.WriteLine("{0,-55} {1,-50}", "Title", "Author");
            foreach (Book book in books)
            {
                Console.WriteLine("{0,-55} {1,-50}", book.Title, book.Author);
            }
            Console.ReadKey();
        }
    }
}

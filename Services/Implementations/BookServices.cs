

using BookApp5.App.Services.Interfaces;
using BookApp5.Core.Models;

namespace BookApp5.App.Services.Implementations
{
    internal class BookServices : IBookServices
    { 
       private Book[] books = { };

        public void Created()
        {
            Book book=new Book();

            Console.WriteLine("Add Name");
            book.Name = Console.ReadLine();

            Console.WriteLine("Add Price");
            book.Price= int.Parse(Console.ReadLine());

            book.CreatedDate= DateTime.UtcNow.AddHours(4);

            Array.Resize(ref books, books.Length + 1);
            books[books.Length-1]= book;
            
        }

        public void Shows()
        {
            if (books.Length == 0)
            {
                Console.WriteLine( "Not aviable");
            }
        
            foreach(Book book in books)
            {
                Console.WriteLine($"Book name:{book.Name}, Book price:{book.Price}, CreatedDate: {book.CreatedDate}");
                
            }
        }
    }
}

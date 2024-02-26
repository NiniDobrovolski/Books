using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books
{
    internal class BookManager
    {
        // Property to store a list of books, initialized with some default books
        public List<Book> BooksList { get; set; } = new List<Book>()
        {
            new Book()
            {
                Title = "1984",
                Author = "George Orwell",
                Year = "1949"
            },
            new Book()
            {
                Title = "To Kill a Mockingbird",
                Author = "Harper Lee",
                Year = "1960"
            },
            new Book()
            {
                Title = "The Great Gatsby",
                Author = "F.Scott Fitzgerald",
                Year = "1925"
            },
            new Book()
            {
                Title = "Pride and Prejudice",
                Author = "Jane Austen",
                Year = "1813"
            },
            new Book()
            {
                Title = "The Catcher in the Rye",
                Author = "J.D.Salinger",
                Year = "1951"
            }
        };

        // Method to add a book to the list
        public void AddBook(Book book)=>BooksList.Add(book);

        // Method to check if a book already exists in the list
        public bool BookExist(Book book)
        {
            // Iterating through the list of books and comparing each book's title, author, and year with the given book
            foreach (var item in BooksList)
            {
                if(item.Title == book.Title && item.Author == book.Author && item.Year == book.Year)
                {
                    return true;
                }
            }
            return false;
        }
        public bool BookExistByTitle(string title)
        {
            // Iterating through the list of books and comparing each book's title
            foreach (var item in BooksList)
            {
                if (item.Title == title)
                {
                    return true;
                }
            }
            return false;
        }

        // Method to search for a book by its title
        public void SearchBook(string title)
        {
            // Using LINQ to search for books with the given title
            var book = BooksList.Where(b => b.Title == title);

            foreach(var item in book)
            {
                Console.WriteLine(item);
            }
        }

        // Method to display the list of books
        public void ShowBooksList() => BooksList.ForEach(Console.WriteLine);
    }
}

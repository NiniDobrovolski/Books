using Books;

int ContinueOrNot = 1, PublicationYear;
string authorLower;
bool loop = true;

// Displaying welcome message and initializing BookManager
Console.WriteLine("Welcome :). Enter the number corresponding to your need");
BookManager bookManager = new BookManager();

while (ContinueOrNot == 1)
{
    // Displaying options to the user
    Console.WriteLine("Add new book - 1");
    Console.WriteLine("Show books list - 2");
    Console.WriteLine("Search book by its title - 3");
    Console.WriteLine("Exit - 4");

    // Reading user input
    string ans = Console.ReadLine();
    if (ans == "1")  //Add new book
    {
        Console.WriteLine("Enter book title");
        string title = Console.ReadLine();
        Console.WriteLine("Enter author");
        string author = Console.ReadLine();
        Console.WriteLine("Enter publication year");
        string year = Console.ReadLine();
        authorLower = author.ToLower();
        Book book = new Book();

        // Validating author name, title and publication year
        try
        {
            while (loop)
            {
                if(author == "")
                {
                    throw new AuthorException();
                }
                for (int i = 0; i < authorLower.Length; i++)
                {
                        if (((int)authorLower[i] < 97 || (int)authorLower[i] > 122) && (int)authorLower[i]!=32)
                        {
                            throw new AuthorException();
                        }
                        else if (!int.TryParse(year, out PublicationYear))
                        {
                            throw new WrongNumberException();
                        }
                        else if(title == "")
                        {
                            throw new TitleException();
                        }
                        else
                        {
                            loop= false;
                        }
                }

            }

            // Adding the book to the book manager
            book = new Book()
            {
                Title = title,
                Author = author,
                Year = year,
            };
            if (bookManager.BookExist(book))
            {
                throw new BookAlreadyExistsException();
            }
            else
            {
                bookManager.AddBook(book);
                Console.WriteLine("Book Added");
                bookManager.ShowBooksList();
            }
        }
        catch(WrongNumberException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch(AuthorException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (BookAlreadyExistsException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (TitleException ex)
        {
            Console.Write(ex.Message);
        }
    }
    else if (ans == "2") //Show books list
    {
        Console.WriteLine("Book list :");
        bookManager.ShowBooksList();
    }
    else if (ans == "3") // Search book by its title
    {
        Console.WriteLine("Enter book's title you want to search");
        string booktitle = Console.ReadLine();       
        if(bookManager.BookExistByTitle(booktitle)==true)
        {
            bookManager.SearchBook(booktitle);
        }
        else
        {
            Console.WriteLine("Book doesn't exist.");
        }
    }
    else if (ans == "4") //Exit
    {
        break;
    }
    else
    {
        Console.WriteLine("Enter correct number");
    }

    // Asking the user if they want to continue
    Console.WriteLine("If you need any other service enter 1, otherwise enter any character");
    string answer = Console.ReadLine();
    if (!int.TryParse(answer, out ContinueOrNot))
    {
        ContinueOrNot = 0;
    }
    else ContinueOrNot = int.Parse(answer);
}

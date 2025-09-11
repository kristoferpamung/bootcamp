namespace Classes;

class Library
{
    // readonly hanya dapat di set di constructor
    public static readonly string LibraryName = "City Central Library";
    private List<Book> _books;

    static Library()
    {
        Console.WriteLine("Initializing Library System...");
    }

    public Library()
    {
        _books = new List<Book>();
    }

    public Book this[int index]
    {
        get
        {
            if (index > _books.Count() - 1)
            {
                return null!;
            }
            else
            {
                return _books[index];
            }
        }
    }

    public Book this[string title]
    {
        get
        {
            Book? bookFound = _books.Find(book => book.Title == title);
            if (bookFound != null)
            {
                return bookFound;
            }
            else
            {
                return null!;
            }
        }
    }

    public void AddBook(Book book)
    {
        _books.Add(book);
    }

    public int GetTotalBook()
    {
        return _books.Count();
    }

    public void PrintAllBooks()
    {
        _books.ForEach((book) => book.DisplayBookDetails());
    }
}
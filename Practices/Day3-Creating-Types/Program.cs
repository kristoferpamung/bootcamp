using System.Dynamic;

Author auhtor1 = new(firstName: "Windah", lastName: "Basudara", 1990);
Book book1 = new(title: "Emang Gitu Liriknya Kocak", author: auhtor1, pages: 255, isbn: "abc", price: -1);

// No 1
Console.WriteLine(auhtor1.ToString());

// No 2;
book1.DisplayBookDetails();
Console.WriteLine(book1.ToString());


public class Author
{
    // Field
    private readonly string _firstName;
    private readonly string _lastName;

    //Property
    public string FullName { get { return _firstName + " " + _lastName; } }

    //Property
    public int YearBorn { get; init; }

    //Constructor
    public Author(string firstName, string lastName, int yearBorn)
    {
        _firstName = firstName;
        _lastName = lastName;
        YearBorn = yearBorn;
    }

    // Method
    public override string ToString()
    {
        return $"Author : {_firstName} {_lastName}, Born: {YearBorn}";
    }
}

public class Book
{
    //Constant
    public const int MaxTitleLength = 100;
    public const decimal DefaultPrice = 25.00M;

    private string _isbn;
    private decimal _price;

    public string Title { get; set; }
    public Author BookAuthor { get; }
    public int Pages { get; }

    public string ISBN
    {
        get
        {
            return _isbn;
        }
        private set
        {
            if (value.Length == 13)
            {
                _isbn = value;
            }
            else
            {
                Console.WriteLine("Warning: ISBN not set. using N/A default value");
                _isbn = "N/A";
            }
        }
    }

    public decimal Price
    {
        get => _price; set
        {
            if (value > 1)
            {
                _price = value;
            }
            else
            {
                Console.WriteLine("Warning: price not set. using DefaultPrice default value");
                _price = DefaultPrice;
            }
        }
    }

    public Book(string title, Author author, int pages, string isbn)
    {
        Title = title;
        BookAuthor = author;
        Pages = pages;
        ISBN = isbn;
    }
    public Book(string title, Author author, int pages, string isbn, decimal price) : this(title, author, pages, isbn)
    {
        Price = price;
    }

    public override string ToString()
    {
        return $"Title: {Title}, Author : {BookAuthor.FullName}, Pages: {Pages}, ISBN: {_isbn}, Price: {_price}";
    }

    public void DisplayBookDetails()
    {
        string FormatTitle() => $"{Title} by {BookAuthor.FullName}";
        Console.WriteLine($"{FormatTitle()} - {Pages} - {_isbn} - {_price}");
    }
}

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
        set
        {
            if (index > _books.Count() - 1)
            {
                Console.WriteLine("Argument out of range!");
            }
            _books[index] = value;
        }
    }

    public Book this[string title]
    {
        get
        {
            Book bookFound = _books.Find(book => book.Title == title);
            if (bookFound != null)
            {
                return bookFound;
            }
            else
            {
                return null;
            }
        }
        set
        {

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
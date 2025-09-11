namespace Classes;

public class Book
{
    //Constant
    public const int MaxTitleLength = 100;
    public const decimal DefaultPrice = 25.00M;

    private string _isbn = string.Empty;
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
        Console.WriteLine($"Title : {FormatTitle()}, Pages: {Pages}, ISBN: {_isbn}, Price: {_price}");
    }
}
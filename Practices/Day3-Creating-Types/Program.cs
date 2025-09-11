using Classes;

Author windah = new(firstName: "Windah", lastName: "Basudara", 1990);
Author zeta = new(firstName: "Vestia", lastName: "Zeta", 2002);

Book book1 = new(title: "Emang Gitu Liriknya Kocak", author: windah, pages: 255, isbn: "ABC1234567890");
Book book2 = new(title: "Iwak", author: zeta, pages: 220, isbn: "ABC1234567890", price: 20_000);
Book book3 = new(title: "Bocil Caper", author: windah, pages: 200, isbn: "ABC", price: 25_000);
Book book4 = new(title: "Kucing", author: zeta, pages: 180, isbn: "ABC1234567890", price: -24_000);

Library library1 = new();
library1.AddBook(book1);
library1.AddBook(book2);
library1.AddBook(book3);
library1.AddBook(book4);

Console.WriteLine($"===== {Library.LibraryName} =====\n");
Console.WriteLine($"Total book: {library1.GetTotalBook()}\n");

Console.WriteLine("===== All Books =====");
library1.PrintAllBooks();

//Indexer
Console.WriteLine("\n===== Book from index 0 =====");
library1[0].DisplayBookDetails();

Console.WriteLine("\n===== Book with title Iwak =====");
library1["Iwak"].DisplayBookDetails();


using System.Text;
using MyEnum;

MyChar.MyChar c = new();

/* Case Conversion */
Console.WriteLine("=== Case Conversion ===");
var case1 = char.ToUpper(c.a);

/* White Space*/
string whiteSpace = $"hello\tworld";

Console.WriteLine(case1);
Console.WriteLine(char.IsWhiteSpace('\t'));
Console.WriteLine(whiteSpace);

Console.WriteLine(char.ToUpper('i'));
Console.WriteLine(char.ToUpperInvariant('i'));

Console.WriteLine(char.GetUnicodeCategory('\t'));
Console.WriteLine(char.GetUnicodeCategory('a'));
Console.WriteLine(char.GetUnicodeCategory('\n'));

Console.WriteLine("\n=== string ===");
string s1 = "Hello";
string s2 = "First Line\r\nSecond Line"; // Escape sequences
string s3 = @"C:\Path\File.txt"; // Verbatim string literal
string s4 = @"Hello' World \"; // Verbatim string literal

Console.WriteLine(s1);
Console.WriteLine(s2);
Console.WriteLine(s3);
Console.WriteLine(s4);

string repeatCharacter = new string('*', 10);
Console.WriteLine(repeatCharacter);

/* array of char to string */
Console.WriteLine("\n== array of char to string ===");
char[] arrayOfChar = "Hello".ToCharArray();
string s = new string(arrayOfChar);
Console.WriteLine(s);

/* empty string */
Console.WriteLine("\n=== Empty String ===");
string empty = "";
Console.WriteLine(empty.Length == 0);
Console.WriteLine(empty == string.Empty);

/* null string */
Console.WriteLine("\n=== Null String ===");
string? nullString = null;
// Console.WriteLine(nullString!.Length == 0); // Exception null reference
Console.WriteLine(nullString == null);
Console.WriteLine(nullString == "");
Console.WriteLine(string.IsNullOrEmpty(nullString));

/* Indexer */
Console.WriteLine("\n=== Indexer ===");
string hello = new("Hello World");
char i = hello[1];
Console.WriteLine(i);

/* foreach */
Console.WriteLine("\n === foreach ===");
foreach (char angka in "123")
{
    Console.WriteLine(angka);
}

/* Searching with string */
Console.WriteLine("\n=== Searching with string ===");
Console.WriteLine(hello.StartsWith('H'));
Console.WriteLine(hello.EndsWith('D'));
Console.WriteLine(hello.Contains('o'));
Console.WriteLine(hello.Contains("ello"));

Console.WriteLine(hello.IndexOf('H'));
Console.WriteLine(hello.LastIndexOf('o'));
Console.WriteLine(hello.LastIndexOf(' '));

string trimString = "   hello      worl   d   ";
Console.WriteLine(trimString.Trim());
Console.WriteLine(trimString.TrimStart());
Console.WriteLine(trimString.TrimEnd());
Console.WriteLine(trimString.Replace(" ", ""));


Console.WriteLine("==== Format String ====");

string composite = "It's {0} degrees in {1} on this {2} morning";
string str = string.Format(composite, 35, "Perth", DateTime.Now.DayOfWeek);
string iniKalimat = "Aku sedang {0} di kos {1} nomor {2} - {3}";
string str2 = string.Format(iniKalimat, "makan", "Pak Di", 4, "Salatiga");
Console.WriteLine(str);
Console.WriteLine(str2);

Console.WriteLine(string.Concat("Hello ", "World"));

string str4 = $"It's hot this {DateTime.Now.DayOfWeek} morning";
// You can still use alignment and format strings:
Console.WriteLine($"Name={"Mary",-20} Credit Limit={500,15:C}");

StringBuilder sb = new();
sb.Append("Hello");
sb.Append(" ");
sb.Append("World!");

Console.WriteLine(sb);

Console.WriteLine(string.Equals("foo", "FOO", StringComparison.CurrentCultureIgnoreCase));


// Date And Times//
/* TimeSpan */
Console.WriteLine(new TimeSpan(2, 30, 0));
Console.WriteLine(new TimeSpan(1,2, 30, 0));
Console.WriteLine(TimeSpan.FromHours(2.5));
Console.WriteLine(TimeSpan.FromHours(-2.5));

Console.WriteLine(TimeSpan.TryParse("0:50:00", out TimeSpan ts));


/* Parse */
string strBool = true.ToString();
Console.WriteLine(strBool);

Console.WriteLine("=== Enum ===");
MyEnum.MyEnum me = new();
me.Display(Size.Large);

int index = (int)BorderSides.Top;       // i == 4
Console.WriteLine(index);
// Integral to enum member:
BorderSides side = (BorderSides)index;
Console.WriteLine(side.ToString());

Console.WindowWidth = Console.LargestWindowWidth;
Console.ForegroundColor = ConsoleColor.Green;
Console.Write("test... 50%");
Console.CursorLeft -= 3; // Move cursor back 3 positions
Console.Write("90%\n");

DateTimeOffset waktuLokal = DateTimeOffset.Now;
DateTimeOffset waktuUTC = waktuLokal.ToUniversalTime();

Console.WriteLine("Lokal: " + waktuLokal);
Console.WriteLine("UTC:   " + waktuUTC);

double d1 = 3.9;
int i1 = Convert.ToInt32(d1);    // i1 == 4 (rounds up)

double d2 = 3.2;
int i2 = Convert.ToInt32(d2);    // i2 == 3 (rounds down)

double d3 = 3.5;
int i3 = Convert.ToInt32(d3);    // i3 == 4 (banker's rounding: rounds to nearest even number)
double d4 = 4.5;
int i4 = Convert.ToInt32(d4);    // i4 == 4 (banker's rounding: rounds to nearest even number)

Console.WriteLine(i1 + " - "+ i2 + " - " + i3 + " - " + i4);

// Enum
enum Size { Small, Medium, Large }
enum Nut { Walnut, Hazelnut, Macadamia }

[Flags] // Indicates this enum can be treated as a bit field
public enum BorderSides { Left = 1, Right = 2, Top = 4, Bottom = 8 }

// Enum member to integral:


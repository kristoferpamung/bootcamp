namespace Classes;

class Person
{
    // Properties static Bisa Digunakan tanpa Instantiate
    public static string Welcome = "Hallo saya manusia";

    // Readonly hanya dapat diisi value saat object dibuat
    private readonly string _name;

    // Public dapat diakses dimanapun
    public int age;

    private string[] _hobbies = ["Makan"];

    // Getter untuk mengakses private field
    public string Name
    {
        get
        {
            return _name;
        }
    }

    //Getter Setter untuk properties HairColor, dapat di set value sesudah di instatiate Person.HairColor = "Black"
    public string HairColor
    {
        get;
        set;
    } = "Black";

    public Person(string name) => _name = name;
    public Person(string name, int age) : this(name)
    {
        this.age = age;
    }
    public Person(string name, int age, string[] hobbies) : this(name, age)
    {
        _hobbies = hobbies;
    }


    // Indexer
    public string this[int index]
    {
        get
        {
            return _hobbies[index];
        }
    }

    public string[] this[Range range]
    {
        get
        {
            return _hobbies[range];
        }
    }
}
namespace Classes;

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
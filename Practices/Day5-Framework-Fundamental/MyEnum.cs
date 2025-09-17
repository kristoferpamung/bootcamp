namespace MyEnum;


class MyEnum
{
    public void Display(Enum value)
    {
        Console.WriteLine(value.GetType().Name + "." + value.ToString());
    }
}
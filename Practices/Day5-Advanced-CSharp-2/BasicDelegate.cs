using System.Data;

namespace BasicDelegate;

public delegate void DelegateWriteLine();
public delegate int? DelegateConvertStringToInt(string value);

public delegate void ShowMessageDelegate(string message);

/* Generic Delegate Type */
/* tipe data T harus sama, jika T adalah int maka T yang lain int juga */
public delegate T Operation<T>(T a, T b);

class MyDelegate
{
    public void DelegateMethod1()
    {
        Console.WriteLine("Delegate Method 1");
    }

    public void DelegateMethod2()
    {
        Console.WriteLine("Delegate Method 2");
    }

    public int? ConvertStringToInt(string value)
    {
        Console.WriteLine("Convert String To Int Dijalankan!");
        if (int.TryParse(value, out int a))
        {
            Console.WriteLine("Value : " + a);
            return a;
        }
        else
        {
            return null;
        }
    }

    public int? ConvertStringToBooleanNumber(string value)
    {
        Console.WriteLine("Convert String To Boolean Int Dijalankan! 0 = false, 1 = true");
        if (value == "true")
        {
            return 1;
        }
        else
        {
            return 0;
        }
    }
    /* Using Delegate in parameter */
    public void ShowMessage(ShowMessageDelegate sm)
    {
        for (int i = 0; i < 10; i++)
        {
            sm((i + 1).ToString());
        }
    }

    public void Show(string a)
    {
        Console.WriteLine("Hello Delegate! " + a);
    }
}

public class Calculator
{
    public T Compute<T>(T x, T y, Operation<T> operation)
    {
        return operation(x, y);
    }

    public TResult ComputeWithDotNet<TResult>(TResult x, TResult y, Func<TResult,TResult,TResult> operation)
    {
        return operation(x, y);
    }
}
namespace BelajarDelegate;

delegate int Transformer(int x);

class Test
{
    public static int Square(int x) => x * x;
    public int Cube(int x) => x * x * x;

}

/* Multicast Delegates */
delegate void SomeDelegate();

/* Multicast Delegates Example */
public delegate void ProgressReporter(int percentComplete);

public class Util
{
    public static void HardWork(ProgressReporter p)
    {
        for (int i = 0; i <= 10; i++)
        {
            p(i * 10);
            System.Threading.Thread.Sleep(100);
        }
    }
}

// Delegate Generic
public delegate TResult TransformerGeneric<TArg, TResult>(TArg arg);

// Bisa disederhanakan dengan Func<TResult> dan Func<TArg, TResult>
public class Util2
{
    public static void Transform<T>(T[] values, Func<T, T> transformer)
    {
        for (int i = 0; i < values.Length; i++)
        {
            values[i] = transformer(values[i]);
        }
    }
}

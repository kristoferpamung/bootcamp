ClassicThreading();

bool _done = false;
new Thread(Go).Start();
Go();
Thread t = new Thread(() => Print("Hello from t!"));
t.Start();
void Print(string message) => Console.WriteLine(message);

void Go()
{
    // Both threads share the same _done variable
    if (!_done) { _done = true; Console.WriteLine("Done"); }
}

static void ClassicThreading()
{
    Thread t1 = new(WriteY);
    Thread t2 = new(WriteZ);
    t1.Start();
    Thread.Sleep(1000); //memberi jeda
                        // t1.Join();

    t2.Start();
    // Thread.Sleep(0);
    Thread.Yield();

    // Main Thread
    for (int i = 0; i < 1000; i++)
    {
        Console.Write("x");
    }
}

static void WriteY()
{
    for (int y = 0; y < 1000; y++)
    {
        Console.Write("y");
    }
}
static void WriteZ()
{
    for (int y = 0; y < 1000; y++)
    {
        Console.Write("z");
    }
}
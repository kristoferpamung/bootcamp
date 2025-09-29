using System.Text;

public class Logic
{
    public int N { get; set; }
    public Dictionary<int, string> Rules { get; private set; } = [];
    public StringBuilder outputString = new();
    public Logic(int n)
    {
        N = n;
    }
    public void AddRule(int input, string output)
    {
        Rules.Add(input, output);
    }
    public void GenerateOutputString()
    {
        for (int i = 1; i <= N; i++)
        {
            bool hasRule = false;
            foreach (KeyValuePair<int, string> keyValue in Rules)
            {
                if (i % keyValue.Key == 0)
                {
                    outputString.Append(keyValue.Value);
                    hasRule = true;
                }
            }
            if (!hasRule)
            {
                outputString.Append(i);
            }
            if (i == N)
            {
                outputString.Append('.');
            }
            else
            {
                outputString.Append(',');
            }
        }
    }
    public void PrintOutput()
    {
        Console.Write(outputString);
    }
}
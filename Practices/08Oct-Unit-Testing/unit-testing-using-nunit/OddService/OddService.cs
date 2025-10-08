namespace OddService;

public class OddService
{
    public bool IsOdd(int candidate)
    {
        if (candidate % 2 == 0)
        {
            return false;
        }
        else
        {
            return true;
        }
    } 
}

using System.Globalization;

namespace PrimeService.Services;

public class PrimeService
{
    public bool IsPrime(int candidate)
    {
        if (candidate < 2)
        {
            return false; // Correctly handles the test case
        }
        if (candidate == 2)
        {
            return true;
        }
        if (candidate % 2 == 0)
        {
            return false;
        }

        int boundary = (int)Math.Floor(Math.Sqrt(candidate));

        for (int i = 3; i <= boundary; i += 2)
        {
            if (candidate % i == 0)
            {
                return false;
            }
        }
        return true;
    }
}

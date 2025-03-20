namespace Utilities;

public static class IntExtensions
{
    public static string ToOrdinal(this int value)
    {
        if (value % 100 >= 11 && value % 100 <= 13)
        {
            return value + "th";
        }

        switch (value % 10)
        {
            case 1:
                return value + "st";
            case 2:
                return value + "nd";
            case 3:
                return value + "rd";
            default:
                return value + "th";
        }
    }
    public static bool IsPrime(this int value)
    {
        if (value <= 1) return false; 
        if (value == 2) return true; 
        if (value % 2 == 0) return false;

        for (int i = 3; i * i <= value; i += 2)
        {
            if (value % i == 0)
                return false;
        }
        return true;
    }
}
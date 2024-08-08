using System.Globalization;

namespace _0007_reverse_integer;

public class Solution1
{
    public int Reverse(int x)
    {
        if (x == 0)
            return 0;

        var sign = 1;
        if (x < 0)
        {
            x *= -1;
            sign = -1;
        }

        var result = 0;
        while (x > 0)
        {
            var digit = x % 10;
            if ((int.MaxValue - 7) / 10 < result)
                return 0;

            result = result * 10 + digit;
            x = (x - digit) / 10;
        }

        return result * sign;
    }
}

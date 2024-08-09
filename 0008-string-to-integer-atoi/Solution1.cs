using System.Runtime.InteropServices;

namespace _0008_string_to_integer_atoi;

public class Solution1
{
    public int MyAtoi(string s)
    {
        var len = s.Length;
        if (len == 0) return 0;

        var cursor = 0;
        var sign = 1;
        var chars = s.AsSpan();

        // trim start whitespace
        while (cursor < len && chars[cursor] == ' ')
            cursor++;

        if (cursor >= len)
            return 0;

        // get sign
        switch (chars[cursor])
        {
            case '-':
                sign = -1;
                cursor++;
                break;
            case '+':
                sign = 1;
                cursor++;
                break;
            default:
                break;
        }

        var result = 0;
        var upperBound = (int.MaxValue - 7) / 10;
        while (cursor < len && char.IsDigit(chars[cursor]))
        {
            var digit = chars[cursor] - '0';

            if (result > upperBound || (result == upperBound && digit > 7))
            {
                return sign == 1 ? int.MaxValue : int.MinValue;
            }

            result = result * 10 + digit;
            cursor++;
        }

        return result * sign;
    }
}

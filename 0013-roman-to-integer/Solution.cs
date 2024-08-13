namespace _0013_roman_to_integer;

public class Solution
{
    public int RomanToInt(string s)
    {
        var chars = s.AsSpan();
        var cursor = chars.Length - 1;
        var result = 0;

        while (cursor >= 0)
        {
            var c = chars[cursor];
            var num = c switch
            {
                'M' => 1000,
                'D' => 500,
                'C' => 100,
                'L' => 50,
                'X' => 10,
                'V' => 5,
                'I' => 1,
                _ => throw new Exception()
            };
            result += num;
            cursor--;
            if (cursor < 0)
                break;

            var nextChar = chars[cursor];
            switch (c)
            {
                case 'V':
                case 'X':
                    if (nextChar == 'I')
                    {
                        result--;
                        cursor--;
                    }
                    break;
                case 'L':
                case 'C':
                    if (nextChar == 'X')
                    {
                        result -= 10;
                        cursor--;
                    }
                    break;
                case 'D':
                case 'M':
                    if (nextChar == 'C')
                    {
                        result -= 100;
                        cursor--;
                    }
                    break;
            }
        }

        return result;
    }
}

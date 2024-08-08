using System.Text;

namespace _0006_zigzag_conversion;

public class Solution1
{
    public static string Convert(string s, int numRows)
    {
        if (numRows <= 1)
            return s;

        var len = s.Length;
        if (len <= 1)
            return s;

        var result = new StringBuilder(len);
        for (var i = 0; i < numRows; i++)
        {
            var cursor = i;
            var period = numRows - 1;
            var firstLoop = 2 * period - 2 * i;
            var secondLoop = 2 * i;
            while (cursor < len)
            {
                if (cursor >= len) continue;
                result.Append(s[cursor]);
                cursor += firstLoop;

                if (cursor >= len) continue;
                if (i != 0 && i != numRows - 1)
                {
                    result.Append(s[cursor]);
                }
                cursor += secondLoop;
            }
        }

        return result.ToString();
    }
}

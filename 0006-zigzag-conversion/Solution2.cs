using System.Text;

namespace _0006_zigzag_conversion;

public class Solution2
{
    public static string Convert(string s, int numRows)
    {
        if (numRows <= 1)
            return s;

        var len = s.Length;
        if (len <= 1)
            return s;

        var result = string.Create(len, s, (buffer, state) =>
        {
            var j = 0;
            var span = state.AsSpan();
            for (var i = 0; i < numRows; i++)
            {
                var cursor = i;
                var period = numRows - 1;
                var firstLoop = 2 * period - 2 * i;
                var secondLoop = 2 * i;
                while (cursor < len)
                {
                    if (cursor >= len) continue;
                    buffer[j] = span[cursor];
                    j++;
                    cursor += firstLoop;

                    if (cursor >= len) continue;
                    if (i != 0 && i != numRows - 1)
                    {
                        buffer[j] = span[cursor];
                        j++;
                    }
                    cursor += secondLoop;
                }
            }
        });

        return result;
    }
}

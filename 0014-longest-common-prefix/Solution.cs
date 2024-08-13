using System.Text;

namespace _0014_longest_common_prefix;

public class Solution
{
    public string LongestCommonPrefix(string[] strs)
    {
        if (strs.Length == 0)
            return string.Empty;

        var sb = new StringBuilder();
        var cursor = 0;
        var finished = false;
        while (!finished)
        {
            char? curChar = null;
            for (var i = 0; i < strs.Length; i++)
            {
                var curString = strs[i];
                if (cursor >= curString.Length)
                {
                    finished = true;
                    break;
                }

                if (i == 0)
                {
                    curChar = curString[cursor];
                    continue;
                }

                if (curChar != curString[cursor])
                {
                    finished = true;
                    break;
                }
            }

            cursor++;
            if (!finished)
                sb.Append(curChar);
        }

        return sb.ToString();
    }
}

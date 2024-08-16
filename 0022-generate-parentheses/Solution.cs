using System.Reflection.PortableExecutable;

namespace _0022_generate_parentheses;

public class Solution
{
    public IList<string> GenerateParenthesis(int n)
    {
        var results = Generate(n, [], 0, 0);
        return results.Select(x => string.Join(string.Empty, x)).ToList();
    }

    public IEnumerable<char[]> Generate(int n, char[] buffer, int position, int opened)
    {
        if (position == 2 * n)
            yield return buffer;
        else
        {
            if (opened < n && 2 * n - position > opened)
            {
                var open = new char[position + 1];
                Array.Copy(buffer, open, position);
                open[position] = '(';
                foreach (var result in Generate(n, open, position + 1, opened + 1))
                    yield return result;
            }

            if (opened > 0)
            {
                var close = new char[position + 1];
                Array.Copy(buffer, close, position);
                close[position] = ')';

                foreach (var result in Generate(n, close, position + 1, opened - 1))
                    yield return result;
            }
        }
    }
}

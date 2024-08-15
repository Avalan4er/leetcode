namespace _0020_valid_parentheses;

public class Solution
{
    public bool IsValid(string s)
    {
        var stack = new Stack<char>();
        var pairs = new Dictionary<char, char>
        {
            ['('] = ')',
            ['{'] = '}',
            ['['] = ']',
        };

        foreach (var c in s.AsSpan())
        {
            switch (c)
            {
                case '{':
                case '(':
                case '[':
                    stack.Push(c);
                    break;
                case '}':
                case ')':
                case ']':
                    if (!stack.TryPop(out var latest) || pairs[latest] != c)
                        return false;
                    break;
            }
        }

        return stack.Count == 0;
    }
}

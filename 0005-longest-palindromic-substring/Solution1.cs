namespace _0005_longest_palindromic_substring;

public class Solution1
{
    private readonly Dictionary<(int, int), (int, int)> _cache = [];

    public string LongestPalindrome(string s)
    {
        var (start, finish) = GetPalindrome(s, 0, s.Length);
        return s[start..finish];
    }

    private (int start, int finish) GetPalindrome(string s, int start, int finish)
    {
        if (IsPalindromic(s, start, finish))
            return (start, finish);

        if (finish > start)
        {
            var leftRange = (start, finish: finish - 1);
            if (!_cache.TryGetValue(leftRange, out var left))
            {
                left = GetPalindrome(s, leftRange.start, leftRange.finish);
                _cache[leftRange] = left;
            }

            var rightRange = (start: start + 1, finish);
            if (!_cache.TryGetValue(rightRange, out var right))
            {
                right = GetPalindrome(s, rightRange.start, rightRange.finish);
                _cache[rightRange] = right;
            }

            if ((left.Item2 - left.Item1) > (right.Item2 - right.Item1))
                return left;
            else
                return right;
        }

        return (start, finish);
    }

    private static bool IsPalindromic(string str, int start, int finish)
    {
        for (int i = start, j = finish - 1; i < finish; i++, j--)
        {
            if (str[i] != str[j])
                return false;
        }
        return true;
    }
}

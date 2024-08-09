namespace _0009_palindrome_number;

public class Solution1
{
    public bool IsPalindrome(int x)
    {
        if (x == 0) return true;
        if (x < 0) return false;

        var length = (int)Math.Floor(Math.Log10(x)) + 1;
        Span<int> digits = stackalloc int[length];

        var cursor = length - 1;
        while (x > 0)
        {
            digits[cursor] = x % 10;
            x = (x - digits[cursor]) / 10;
            cursor--;
        }

        for (int i = 0, j = length - 1; i < length / 2; i++, j--)
            if (digits[i] != digits[j])
                return false;

        return true;
    }
}

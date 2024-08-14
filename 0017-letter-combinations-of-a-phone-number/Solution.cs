namespace _0017_letter_combinations_of_a_phone_number;

public class Solution
{
    private readonly Dictionary<char, char[]> _digitMap = new()
    {
        ['2'] = ['a', 'b', 'c'],
        ['3'] = ['d', 'e', 'f'],
        ['4'] = ['g', 'h', 'i'],
        ['5'] = ['j', 'k', 'l'],
        ['6'] = ['m', 'n', 'o'],
        ['7'] = ['p', 'q', 'r', 's'],
        ['8'] = ['t', 'u', 'v'],
        ['9'] = ['w', 'x', 'y', 'z'],
    };

    public IList<string> LetterCombinations(string digits)
    {
        if (digits.Length == 0)
            return [];

        var result = new List<string>((int)Math.Pow(4, digits.Length));
        result.AddRange(GetCombinations(string.Empty, digits, 0));
        return result;
    }

    public IEnumerable<string> GetCombinations(string prefix, string digits, int depth)
    {
        var digit = digits[depth];
        var length = prefix.Length + 1;
        var target = digits.Length;
        foreach (var letter in _digitMap[digit])
        {
            var str = prefix + letter;
            if (length == target)
                yield return str;
            else
                foreach (var res in GetCombinations(str, digits, depth + 1))
                    yield return res;
        }
    }
}

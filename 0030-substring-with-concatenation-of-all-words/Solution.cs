namespace _0030_substring_with_concatenation_of_all_words;

public class Solution
{
    public IList<int> FindSubstring(string s, string[] words)
    {
        if (string.IsNullOrEmpty(s))
            return [];
        if (words.Length == 0)
            return [];

        var searchMap = CreateSearchMap(words);
        var wLen = words[0].Length;
        var sLen = s.Length;
        var data = s.AsSpan();
        var wCount = words.Length;
        var substrLen = wLen * wCount;

        var result = new List<int>();
        for (var i = 0; i < sLen - substrLen + 1; i++)
        {
            var map = Search(data.Slice(i, substrLen), wLen, searchMap);
            if (map is null) continue;
            if (searchMap.SequenceEqual(map))
                result.Add(i);
        }

        return result;
    }

    private static SortedDictionary<string, int> CreateSearchMap(string[] words)
    {
        var result = new SortedDictionary<string, int>();

        foreach (var word in words)
        {
            if (!result.ContainsKey(word))
                result[word] = 0;
            result[word]++;
        }

        return result;
    }

    private static Dictionary<string, int>? Search(ReadOnlySpan<char> input, int wordLength, SortedDictionary<string, int> searchMap)
    {
        var result = searchMap.ToDictionary(x => x.Key, x => 0);
        var inputLength = input.Length;

        for (var i = 0; i < inputLength; i += wordLength)
        {
            var word = input.Slice(i, wordLength).ToString();
            if (!result.TryGetValue(word, out var value))
                return null;
            result[word] = ++value;
        }

        return result;
    }
}

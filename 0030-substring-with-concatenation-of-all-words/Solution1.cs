using System.Security.Cryptography.X509Certificates;

namespace _0030_substring_with_concatenation_of_all_words;

public class Solution1
{
    public IList<int> FindSubstring(string s, string[] words)
    {
        if (string.IsNullOrEmpty(s))
            return [];
        if (words.Length == 0)
            return [];

        var index = 0;
        var sLen = s.Length;
        var result = new List<int>();
        var chainLength = words.Length * words[0].Length - 1;
        while (index < sLen - chainLength)
        {
            var chainIdx = CheckChain(s, index, words);
            if (chainIdx != -1)
                result.Add(index);
            index++;
        }

        return result;
    }

    private static int CheckChain(ReadOnlySpan<char> s, int start, string[] words)
    {
        var search = new List<string>(words);
        var chainIndex = start;
        var wordLen = words[0].Length;
        while (search.Count > 0 && chainIndex < s.Length)
        {
            var substring = s.Slice(chainIndex, wordLen);
            var wordIdx = FindWord(substring, search);
            if (wordIdx != -1)
            {
                var word = search[wordIdx];
                search.RemoveAt(wordIdx);
                chainIndex += word.Length;
            }
            else
            {
                return -1;
            }
        }

        return search.Count > 0 ? -1 : start;
    }

    private static int FindWord(ReadOnlySpan<char> s, List<string> words)
    {
        for (var i = 0; i < words.Count; i++)
        {
            var word = words[i];
            if (s.SequenceEqual(word))
                return i;
        }

        return -1;
    }
}

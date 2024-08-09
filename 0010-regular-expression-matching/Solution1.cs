using System.Collections;
using System.ComponentModel;
using System.Runtime.InteropServices;
using Microsoft.VisualStudio.TestPlatform.ObjectModel.Client;

namespace _0010_regular_expression_matching;

public class Solution1
{
    public bool IsMatch(string s, string p)
    {
        var groups = GetGroups(p).Reverse().ToArray().AsSpan();
        var chars = s.AsSpan();

        return TryMatch(groups, chars);
    }

    private static bool TryMatch(ReadOnlySpan<MatchGroup> groups, ReadOnlySpan<char> chars)
    {
        var cursor = 0;
        var groupIdx = 0;
        var groupFinished = false;
        while (cursor < chars.Length && groupIdx < groups.Length)
        {
            var group = groups[groupIdx];
            if (groupFinished)
            {
                groupIdx++;
                groupFinished = false;
                continue;
            }

            var c = chars[cursor];
            var match = group.Match(c);
            if (!match)
            {
                groupFinished = true;
                if (group.Repeating && groupFinished)
                    continue;
                else
                    return false;
            }

            if (!group.Repeating) groupFinished = true;

            if (groupIdx < groups.Length - 1 && cursor < chars.Length && TryMatch(groups[(groupIdx + 1)..], chars[cursor..]))
                return true;

            cursor++;
            if (cursor == chars.Length && groupIdx < groups.Length)
            {
                for (var i = groupIdx + 1; i < groups.Length; i++)
                    if (!groups[i].Repeating)
                        return false;
                groupIdx++;
            }
        }

        if (cursor < chars.Length || groupIdx < groups.Length)
            return false;

        return true;
    }

    private static IEnumerable<MatchGroup> GetGroups(string pattern)
    {
        var end = pattern.Length;
        var cursor = end - 1;
        var repeating = false;
        while (cursor >= 0)
        {
            var c = pattern[cursor];
            if (c == '*')
            {
                repeating = true;
                if (cursor == 0)
                    yield return new(c, repeating);
            }
            else
            {
                yield return new(c, repeating);
                repeating = false;
            }
            cursor--;
        }
    }

    class MatchGroup(char c, bool repeating)
    {
        public bool Repeating { get; } = repeating;

        public bool Match(char i)
        {
            return i == c || c == '.';
        }
    }
}

namespace _0028_find_the_index_of_the_first_occurrence_in_a_string;

public class SolutionTests
{
    [Theory]
    [InlineData("sadbutsad", "sad", 0)]
    [InlineData("leetcode", "leeto", -1)]
    [InlineData("aaa", "aaaa", -1)]
    [InlineData("mississippi", "issip", 4)]
    [InlineData("a", "a", 0)]
    public void Case1(string haystack, string needle, int expected)
    {
        var sln = new Solution();

        var result = sln.StrStr(haystack, needle);

        Assert.Equal(expected, result);
    }
}

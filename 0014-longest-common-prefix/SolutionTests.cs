namespace _0014_longest_common_prefix;

public class SolutionTests
{
    [Fact]
    public void Case1()
    {
        var sln = new Solution();

        var result = sln.LongestCommonPrefix(["flower", "flow", "flight"]);

        Assert.Equal("fl", result);
    }

    [Fact]
    public void Case2()
    {
        var sln = new Solution();

        var result = sln.LongestCommonPrefix(["dog", "racecar", "car"]);

        Assert.Equal("", result);
    }
}

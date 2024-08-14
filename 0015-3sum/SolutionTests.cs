using System.Diagnostics.CodeAnalysis;

namespace _0015_3sum;

public class SolutionTests
{
    [Fact]
    public void Case1()
    {
        var sln = new Solution();

        var result = sln.ThreeSum([-1, 0, 1, 2, -1, -4]);

        Assert.True(result.SequenceEqual([[2, -1, -1], [1, 0, -1]], new IListComparer()));
    }

    [Fact]
    public void Case2()
    {
        var sln = new Solution();

        var result = sln.ThreeSum([0, 1, 1]);

        Assert.True(result.SequenceEqual([], new IListComparer()));
    }

    [Fact]
    public void Case3()
    {
        var sln = new Solution();

        var result = sln.ThreeSum([0, 0, 0]);

        Assert.True(result.SequenceEqual([[0, 0, 0]], new IListComparer()));
    }

    [Fact]
    public void Case4()
    {
        var sln = new Solution();

        var input = Enumerable.Range(0, 3000).Select(_ => Random.Shared.Next(-1000, 1000)).ToArray();
        var result = sln.ThreeSum(input);

        var except = result.Any();
        Assert.True(except);
    }
}

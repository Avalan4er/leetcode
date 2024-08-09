namespace _0010_regular_expression_matching;

public class SolutionTests
{
    [Fact]
    public void Case1()
    {
        var sln = new Solution1();

        var result = sln.IsMatch("aa", "a");

        Assert.False(result);
    }

    [Fact]
    public void Case2()
    {
        var sln = new Solution1();

        var result = sln.IsMatch("aa", "a*");

        Assert.True(result);
    }

    [Fact]
    public void Case3()
    {
        var sln = new Solution1();

        var result = sln.IsMatch("ab", ".*");

        Assert.True(result);
    }

    [Fact]
    public void Case4()
    {
        var sln = new Solution1();

        var result = sln.IsMatch("aaaabaaaabbbb", "a*ba*b*");

        Assert.True(result);
    }

    [Fact]
    public void Case5()
    {
        var sln = new Solution1();

        var result = sln.IsMatch("aaaabaaaabbbb", "a*b.*");

        Assert.True(result);
    }

    [Fact]
    public void Case6()
    {
        var sln = new Solution1();

        var result = sln.IsMatch("aaaabaaaabbbb", "a*.a*b*");

        Assert.True(result);
    }

    [Fact]
    public void Case7()
    {
        var sln = new Solution1();

        var result = sln.IsMatch("aab", "c*a*b");

        Assert.True(result);
    }

    [Fact]
    public void Case8()
    {
        var sln = new Solution1();

        var result = sln.IsMatch("aaaabaaaa", "a.*b*.*a*");

        Assert.True(result);
    }

    [Fact]
    public void Case9()
    {
        var sln = new Solution1();

        var result = sln.IsMatch("ababbbba", "a.*b*.*a*a");

        Assert.True(result);
    }

    [Fact]
    public void Case10()
    {
        var sln = new Solution1();

        var result = sln.IsMatch("ababbbb", "a.*b*.*a*a");

        Assert.False(result);
    }
}

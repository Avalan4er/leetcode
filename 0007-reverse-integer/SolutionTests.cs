namespace _0007_reverse_integer;

public class SolutionTests
{
    [Fact]
    public void Case1()
    {
        var sln = new Solution1();

        var result = sln.Reverse(123);

        Assert.Equal(321, result);
    }

    [Fact]
    public void Case2()
    {
        var sln = new Solution1();

        var result = sln.Reverse(-123);

        Assert.Equal(-321, result);
    }

    [Fact]
    public void Case3()
    {
        var sln = new Solution1();

        var result = sln.Reverse(120);

        Assert.Equal(21, result);
    }

    [Fact]
    public void Case4()
    {
        var sln = new Solution1();

        var result = sln.Reverse(1463847412);

        Assert.Equal(2147483641, result);
    }

    [Fact]
    public void Case5()
    {
        var sln = new Solution1();

        var result = sln.Reverse(1534236469);

        Assert.Equal(0, result);
    }
}

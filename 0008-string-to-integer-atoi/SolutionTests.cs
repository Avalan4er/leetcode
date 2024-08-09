namespace _0008_string_to_integer_atoi;

public class SolutionTests
{
    private readonly Solution1 _sln = new();

    [Fact]
    public void Case1()
    {
        var result = _sln.MyAtoi("42");
        Assert.Equal(42, result);
    }

    [Fact]
    public void Case2()
    {
        var result = _sln.MyAtoi("   -042");
        Assert.Equal(-42, result);
    }

    [Fact]
    public void Case3()
    {
        var result = _sln.MyAtoi("1337c0d3");
        Assert.Equal(1337, result);
    }

    [Fact]
    public void Case4()
    {
        var result = _sln.MyAtoi("0-1");
        Assert.Equal(0, result);
    }

    [Fact]
    public void Case5()
    {
        var result = _sln.MyAtoi("words and 987");
        Assert.Equal(0, result);
    }

    [Fact]
    public void Case6()
    {
        var result = _sln.MyAtoi("-91283472332");
        Assert.Equal(int.MinValue, result);
    }

    [Fact]
    public void Case7()
    {
        var result = _sln.MyAtoi("2147483648");
        Assert.Equal(int.MaxValue, result);
    }

    [Fact]
    public void Case8()
    {
        var result = _sln.MyAtoi(int.MinValue.ToString());
        Assert.Equal(int.MinValue, result);
    }

    [Fact]
    public void Case9()
    {
        var result = _sln.MyAtoi((int.MinValue + 1).ToString());
        Assert.Equal(int.MinValue + 1, result);
    }
}

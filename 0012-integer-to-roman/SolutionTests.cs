namespace _0012_integer_to_roman;

public class SolutionTests
{
    [Fact]
    public void Case1()
    {
        var sln = new Solution();

        var result = sln.IntToRoman(3749);

        Assert.Equal("MMMDCCXLIX", result);
    }

    [Fact]
    public void Case2()
    {
        var sln = new Solution();

        var result = sln.IntToRoman(58);

        Assert.Equal("LVIII", result);
    }

    [Fact]
    public void Case3()
    {
        var sln = new Solution();

        var result = sln.IntToRoman(1994);

        Assert.Equal("MCMXCIV", result);
    }

    [Fact]
    public void Case4()
    {
        var sln = new Solution();

        var result = sln.IntToRoman(10);

        Assert.Equal("X", result);
    }
}

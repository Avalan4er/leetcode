namespace _0011_container_with_most_water;

public class SolutionTests
{
    [Fact]
    public void Case1()
    {
        var sln = new Solution2();

        var result = sln.MaxArea([1, 8, 6, 2, 5, 4, 8, 3, 7]);

        Assert.Equal(49, result);
    }

    [Fact]
    public void Case2()
    {
        var sln = new Solution2();

        var result = sln.MaxArea([1, 1]);

        Assert.Equal(1, result);
    }

    [Fact]
    public void Case3()
    {
        var sln = new Solution2();

        var result = sln.MaxArea(CaseData.Case3);

        Assert.Equal(705634720, result);
    }

    [Fact]
    public void Case4()
    {
        var sln = new Solution2();

        var result = sln.MaxArea([2, 0]);

        Assert.Equal(0, result);
    }
}

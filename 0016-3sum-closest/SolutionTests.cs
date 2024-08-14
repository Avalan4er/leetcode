namespace _0016_3sum_closest;

public class SolutionTests
{
    [Fact]
    public void Case1()
    {
        var sln = new Solution();

        var result = sln.ThreeSumClosest([-1, 2, 1, -4], 1);

        Assert.Equal(2, result);
    }

    [Fact]
    public void Case2()
    {
        var sln = new Solution();

        var result = sln.ThreeSumClosest([0, 0, 0], 1);

        Assert.Equal(0, result);
    }

    [Fact]
    public void Case3()
    {
        var sln = new Solution();

        var data = Enumerable.Range(0, 500).Select(_ => Random.Shared.Next(-1000, 1000)).ToArray();
        var result = sln.ThreeSumClosest(data, 1);

        Assert.Equal(1, result);
    }
}

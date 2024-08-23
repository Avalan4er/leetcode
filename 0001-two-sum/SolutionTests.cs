namespace _0001_two_sum;

public class SolutionTests
{
    [Fact]
    public void Case1()
    {
        var sln = new Solution();

        var result = sln.TwoSum([2, 7, 11, 15], 9);

        Assert.Equal([0, 1], result);
    }

    [Fact]
    public void Case2()
    {
        var sln = new Solution();

        var result = sln.TwoSum([3,2,4], 6);

        Assert.Equal([1, 2], result);
    }

    [Fact]
    public void Case3()
    {
        var sln = new Solution();

        var result = sln.TwoSum([3, 3], 6);

        Assert.Equal([0, 1], result);
    }
}

namespace _0004_median_of_two_sorted_arrays;

public class SolutionTests
{
    [Fact]
    public void Test1()
    {
        var sln = new Solution2();

        var result = sln.FindMedianSortedArrays(
            [1,3],
            [2]
        );

        Assert.Equal(2d, result, 0.00001);
    }

    [Fact]
    public void Test2()
    {
        var sln = new Solution2();

        var result = sln.FindMedianSortedArrays(
            [1,2],
            [3,4]
        );

        Assert.Equal(2.5d, result, 0.00001);
    }
}
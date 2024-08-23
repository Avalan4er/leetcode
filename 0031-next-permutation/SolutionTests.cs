namespace _0031_next_permutation;

public class SolutionTests
{
    [Fact]
    public void Case1()
    {
        var sln = new Solution();

        int[] input = [1, 2, 3];
        sln.NextPermutation(input);

        Assert.Equal([1, 3, 2], input);
    }

    [Fact]
    public void Case2()
    {
        var sln = new Solution();

        int[] input = [3, 2, 1];
        sln.NextPermutation(input);

        Assert.Equal([1, 2, 3], input);
    }

    [Fact]
    public void Case3()
    {
        var sln = new Solution();

        int[] input = [1, 1, 5];
        sln.NextPermutation(input);

        Assert.Equal([1, 5, 1], input);
    }

    [Fact]
    public void Case4()
    {
        var sln = new Solution();

        int[] input = [1, 3, 2];
        sln.NextPermutation(input);

        Assert.Equal([2, 1, 3], input);
    }

    [Fact]
    public void Case5()
    {
        var sln = new Solution();

        int[] input = [2, 3, 1];
        sln.NextPermutation(input);

        Assert.Equal([3, 1, 2], input);
    }

    [Fact]
    public void Case6()
    {
        var sln = new Solution();

        int[] input = [3, 1, 2];
        sln.NextPermutation(input);

        Assert.Equal([3, 2, 1], input);
    }

    [Fact]
    public void Case7()
    {
        var sln = new Solution();

        int[] input = [1, 5, 1];
        sln.NextPermutation(input);

        Assert.Equal([5, 1, 1], input);
    }
}

namespace _0026_remove_duplicates_from_sorted_array;

public class SolutionTests
{
    [Fact]
    public void Case1()
    {
        var sln = new Solution();

        int[] data = [1, 1, 2];
        var result = sln.RemoveDuplicates(data);

        Assert.Equal(2, result);
    }

    [Fact]
    public void Case2()
    {
        var sln = new Solution();

        int[] data = [0, 0, 1, 1, 1, 2, 2, 3, 3, 4];
        var result = sln.RemoveDuplicates(data);

        Assert.Equal(5, result);
    }
}

namespace _0027_remove_element;

public class SolutionTests
{
    [Fact]
    public void Case1()
    {
        var sln = new Solution();

        int[] data = [3, 2, 2, 3];
        var result = sln.RemoveElement(data, 3);

        Assert.Equal(2, result);
    }

    [Fact]
    public void Case2()
    {
        var sln = new Solution();

        int[] data = [0, 1, 2, 2, 3, 0, 4, 2];
        var result = sln.RemoveElement(data, 2);

        Assert.Equal(5, result);
    }
}

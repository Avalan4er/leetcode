namespace _0029_divide_two_integers;

public class SolutionTests
{
    [Theory]
    [InlineData(10, 3, 3)]
    [InlineData(7, -3, -2)]
    [InlineData(-10, -3, 3)]
    [InlineData(int.MaxValue, -3, -715827882)]
    [InlineData(1, 1, 1)]
    [InlineData(1, -1, -1)]
    [InlineData(int.MinValue, -1, int.MaxValue)]
    [InlineData(int.MinValue, int.MinValue, 1)]
    public void Case(int dividend, int divisor, int expected)
    {
        var sln = new Solution();

        var result = sln.Divide(dividend, divisor);

        Assert.Equal(expected, result);
    }
}

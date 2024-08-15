namespace _0020_valid_parentheses;

public class SolutionTests
{
    [Theory]
    [InlineData("()", true)]
    [InlineData("()[]{}", true)]
    [InlineData("(]", false)]
    public void Case(string str, bool expected)
    {
        var sln = new Solution();

        var result = sln.IsValid(str);

        Assert.Equal(expected, result);
    }
}

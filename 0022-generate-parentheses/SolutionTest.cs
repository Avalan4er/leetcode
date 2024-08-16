namespace _0022_generate_parentheses;

public class SolutionTest
{
    [Fact]
    public void Case1()
    {
        var sln = new Solution();

        var result = sln.GenerateParenthesis(3);

        Assert.Equal(["((()))", "(()())", "(())()", "()(())", "()()()"], result);
    }

    [Fact]
    public void Case2()
    {
        var sln = new Solution();

        var result = sln.GenerateParenthesis(1);

        Assert.Equal(["()"], result);
    }
}

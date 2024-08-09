namespace _0009_palindrome_number;

public class SolutionTests
{
    [Fact]
    public void Case1()
    {
        var sln = new Solution1();

        var result = sln.IsPalindrome(121);

        Assert.True(result);
    }

    [Fact]
    public void Case2()
    {
        var sln = new Solution1();

        var result = sln.IsPalindrome(-121);

        Assert.False(result);
    }

    [Fact]
    public void Case3()
    {
        var sln = new Solution1();

        var result = sln.IsPalindrome(10);

        Assert.False(result);
    }
}

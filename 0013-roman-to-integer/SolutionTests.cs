namespace _0013_roman_to_integer;

public class SolutionTests
{
    [Theory]
    [InlineData("III", 3)]
    [InlineData("LVIII", 58)]
    [InlineData("MCMXCIV", 1994)]
    public void Case1(string input, int output)
    {
        var sln = new Solution();

        var result = sln.RomanToInt(input);

        Assert.Equal(output, result);
    }
}

namespace _0017_letter_combinations_of_a_phone_number;

public class SolutionTests
{
    [Fact]
    public void Case1()
    {
        var sln = new Solution();

        var result = sln.LetterCombinations("23");

        Assert.True(result.SequenceEqual(["ad", "ae", "af", "bd", "be", "bf", "cd", "ce", "cf"]));
    }

    [Fact]
    public void Case2()
    {
        var sln = new Solution();

        var result = sln.LetterCombinations("");

        Assert.True(result.SequenceEqual([]));
    }

    [Fact]
    public void Case3()
    {
        var sln = new Solution();

        var result = sln.LetterCombinations("2");

        Assert.True(result.SequenceEqual(["a", "b", "c"]));
    }
}

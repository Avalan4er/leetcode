namespace _0006_zigzag_conversion;

public class SolutionTests
{
    [Fact]
    public void Test1()
    {
        var result = Solution1.Convert("PAYPALISHIRING", 3);

        Assert.Equal("PAHNAPLSIIGYIR", result);
    }

    [Fact]
    public void Test2()
    {
        var result = Solution1.Convert("PAYPALISHIRING", 4);

        Assert.Equal("PINALSIGYAHRPI", result);
    }

    [Fact]
    public void Test3()
    {
        var result = Solution1.Convert("A", 1);

        Assert.Equal("A", result);
    }
}

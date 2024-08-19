namespace _0024_swap_nodes_in_pairs;

public class SolutionTest
{
    [Fact]
    public void Case1()
    {
        var sln = new Solution();
        var result = sln.SwapPairs(ListNode.New([1, 2, 3, 4]));
        Assert.Equal(ListNode.New([2, 1, 4, 3]), result);
    }

    [Fact]
    public void Case2()
    {
        var sln = new Solution();
        var result = sln.SwapPairs(null);
        Assert.Null(result);
    }

    [Fact]
    public void Case3()
    {
        var sln = new Solution();
        var result = sln.SwapPairs(ListNode.New([1]));
        Assert.Equal(ListNode.New([1]), result);
    }
}

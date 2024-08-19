namespace _0025_reverse_nodes_in_k_group;

public class SolutionTests
{
    [Fact]
    public void Case1()
    {
        var sln = new Solution();

        var result = sln.ReverseKGroup(ListNode.New([1, 2, 3, 4, 5]), 2);

        Assert.Equal(ListNode.New([2, 1, 4, 3, 5]), result);
    }

    [Fact]
    public void Case2()
    {
        var sln = new Solution();

        var result = sln.ReverseKGroup(ListNode.New([1, 2, 3, 4, 5]), 3);

        Assert.Equal(ListNode.New([3, 2, 1, 4, 5]), result);
    }

    [Fact]
    public void Case3()
    {
        var sln = new Solution();

        var result = sln.ReverseKGroup(null, 1);

        Assert.Null(result);
    }
}

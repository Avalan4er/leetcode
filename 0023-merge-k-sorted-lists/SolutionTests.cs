namespace _0023_merge_k_sorted_lists;

public class SolutionTests
{
    [Fact]
    public void Case1()
    {
        var sln = new Solution();
        ListNode[] lists = [
            ListNode.New([1, 4, 5]),
            ListNode.New([1, 3, 4]),
            ListNode.New([2, 6])];

        var result = sln.MergeKLists(lists);

        var expected = ListNode.New([1, 1, 2, 3, 4, 4, 5, 6]);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Case2()
    {
        var sln = new Solution();

        var result = sln.MergeKLists([]);

        Assert.Null(result);
    }

    [Fact]
    public void Case3()
    {
        var sln = new Solution();

        var result = sln.MergeKLists(null);

        Assert.Null(result);
    }

    [Fact]
    public void Case4()
    {
        var sln = new Solution();

        var result = sln.MergeKLists([null]);

        Assert.Null(result);
    }
}

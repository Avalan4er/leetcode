namespace _0019_remove_nth_node_from_end_of_list;

public class SolutionTests
{
    [Fact]
    public void Case1()
    {
        var sln = new Solution();
        var head = new ListNode(1, new(2, new(3, new(4, new(5)))));

        var result = sln.RemoveNthFromEnd(head, 2);

        var expected = new ListNode(1, new(2, new(3, new(5))));
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Case2()
    {
        var sln = new Solution();
        var head = new ListNode(1);

        var result = sln.RemoveNthFromEnd(head, 1);

        Assert.Null(result);
    }

    [Fact]
    public void Case3()
    {
        var sln = new Solution();
        var head = new ListNode(1, new(2));

        var result = sln.RemoveNthFromEnd(head, 1);

        Assert.Equal(new(1), result);
    }
}

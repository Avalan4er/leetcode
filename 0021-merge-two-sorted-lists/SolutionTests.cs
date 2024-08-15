using Microsoft.VisualBasic;

namespace _0021_merge_two_sorted_lists;

public class SolutionTests
{
    [Fact]
    public void Case1()
    {
        var sln = new Solution();

        var result = sln.MergeTwoLists(
            CreateList([1, 2, 4]),
            CreateList([1, 3, 4]));

        Assert.Equal(CreateList([1, 1, 2, 3, 4, 4]), result);
    }

    [Fact]
    public void Case2()
    {
        var sln = new Solution();

        var result = sln.MergeTwoLists(null, null);

        Assert.Null(result);
    }

    [Fact]
    public void Case3()
    {
        var sln = new Solution();

        var result = sln.MergeTwoLists(null, CreateList([0]));

        Assert.Equal(CreateList([0]), result);
    }

    private static ListNode CreateList(ReadOnlySpan<int> numbers)
    {
        var current = new ListNode(numbers[0]);
        var head = current;
        var idx = 1;
        while (idx < numbers.Length)
        {
            current.next = new(numbers[idx]);
            current = current.next;
            idx++;
        }

        return head;
    }
}

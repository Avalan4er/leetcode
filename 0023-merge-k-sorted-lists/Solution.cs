
namespace _0023_merge_k_sorted_lists;

public class Solution
{
    public ListNode? MergeKLists(ListNode?[]? lists)
    {
        if (lists is null)
            return null;

        var (head, headIdx) = Min(lists);
        if (head is null)
            return null;
        lists[headIdx] = head.next;

        var current = head;
        while (true)
        {
            var (min, minIdx) = Min(lists);
            if (min is null)
                break;
            current!.next = min;
            current = min;
            lists[minIdx] = min.next;
        }

        return head;
    }

    private static (ListNode? node, int idx) Min(ListNode?[] lists)
    {
        if (lists.Length == 0)
            return (null, 0);

        var minimal = lists[0];
        var minimalIdx = 0;

        for (var i = 1; i < lists.Length; i++)
        {
            var current = lists[i];
            if (current is null)
                continue;

            if (minimal is null || minimal.val > current.val)
            {
                minimal = current;
                minimalIdx = i;
            }
        }

        return (minimal, minimalIdx);
    }
}

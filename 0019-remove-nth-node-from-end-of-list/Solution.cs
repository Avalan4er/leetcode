namespace _0019_remove_nth_node_from_end_of_list;

public class ListNode
{
    public int val;
    public ListNode? next;
    public ListNode(int val = 0, ListNode? next = null)
    {
        this.val = val;
        this.next = next;
    }

    public override bool Equals(object? obj)
    {
        if (obj is null)
            return false;

        if (obj is not ListNode node)
            return false;

        return GetHashCode() == node.GetHashCode();
    }

    public override int GetHashCode()
    {
        var hash = val * 125166326;

        if (next is not null)
            hash += next.GetHashCode();

        return hash;
    }
}

public class Solution
{
    public ListNode RemoveNthFromEnd(ListNode head, int n)
    {
        var removed = Remove(head, n, 0);
        if (removed == -1)
            return head.next!;
        if (removed is null)
            throw new Exception();
        return head;
    }

    public int? Remove(ListNode current, int n, int depth)
    {
        int? nodeIdxToRemove;
        if (current.next is null)
            nodeIdxToRemove = depth - n;
        else
            nodeIdxToRemove = Remove(current.next, n, depth + 1);

        if (nodeIdxToRemove != null && nodeIdxToRemove == depth)
        {
            current.next = current.next!.next;
        }

        return nodeIdxToRemove;
    }
}

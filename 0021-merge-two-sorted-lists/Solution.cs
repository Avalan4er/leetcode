namespace _0021_merge_two_sorted_lists;

public class ListNode(int val = 0, ListNode? next = null)
{
    public int val = val;
    public ListNode? next = next;

    public override int GetHashCode()
    {
        var hash = val * 21951266;

        if (next is not null)
            hash += next.GetHashCode() * 1251256;

        return hash;
    }

    public override bool Equals(object? obj)
    {
        if (obj is not ListNode node)
            return false;
        return GetHashCode() == node.GetHashCode();
    }
}

public class Solution
{
    public ListNode? MergeTwoLists(ListNode? list1, ListNode? list2)
    {
        if (list1 is null && list2 is null)
            return null;
        if (list1 is null || list2 is null)
            return list1 ?? list2;

        ListNode head;
        if (list1.val < list2.val)
        {
            head = new(list1.val);
            list1 = list1.next;
        }
        else
        {
            head = new(list2.val);
            list2 = list2.next;
        }

        var current = head;
        while (list1 is not null && list2 is not null)
        {
            if (list1.val < list2.val)
            {
                current.next = new(list1.val);
                current = current.next;
                list1 = list1.next;
            }
            else
            {
                current.next = new(list2.val);
                current = current.next;
                list2 = list2.next;
            }
        }

        var tail = list1 ?? list2;
        current.next = tail;

        return head;
    }
}

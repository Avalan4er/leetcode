namespace _0024_swap_nodes_in_pairs;

public class Solution
{
    public ListNode? SwapPairs(ListNode? head)
    {
        if (head is null)
            return null;

        ListNode? current = head;
        ListNode? next = head.next;
        ListNode? result = null;
        ListNode? newHead = null;
        while (current is not null)
        {
            if (next is null)
            {
                if (result is null)
                {
                    result = new(current.val);
                    newHead = result;
                }
                else
                {
                    result.next = new(current.val);
                    result = result.next;
                }
            }
            else
            {
                if (result is null)
                {
                    result = new(next.val, new(current.val));
                    newHead = result;
                    result = result.next;
                }
                else
                {
                    result.next = new(next.val, new(current.val));
                    result = result.next.next;
                }
            }

            current = next?.next;
            next = current?.next;
        }

        return newHead;
    }
}

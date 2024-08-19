using System.Runtime.Intrinsics.Arm;
using System.Transactions;

namespace _0025_reverse_nodes_in_k_group;

public class Solution
{
    public ListNode? ReverseKGroup(ListNode? head, int k)
    {
        if (head is null)
            return null;

        var result = new ListNode(0);
        var dummy = result;
        var buffer = new Span<ListNode>(new ListNode[k]);
        var index = 0;
        while (head is not null)
        {
            buffer[index] = head;
            head = head.next;

            index++;
            if (index == k)
            {
                index--;
                while (index != 0)
                    buffer[index].next = buffer[--index];

                dummy.next = buffer[^1];
                dummy = buffer[0];
            }
        }

        if (index > 0)
            dummy.next = buffer[0];
        else
            dummy.next = null;

        return result.next;
    }
}

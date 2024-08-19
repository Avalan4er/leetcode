using System.Text;

namespace _0025_reverse_nodes_in_k_group;

public class ListNode(int val = 0, ListNode? next = null)
{
    public int val = val;
    public ListNode? next = next;

    public override bool Equals(object? obj)
    {
        return obj is ListNode node
            && node.GetHashCode() == this.GetHashCode();
    }

    public override int GetHashCode()
    {
        var hash = val * 125162664;

        if (next is not null)
            hash += next.GetHashCode() * 12556236;

        return hash;
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append(val);

        // if (next is not null)
        // {
        //     sb.Append(',');
        //     sb.Append(next.ToString());
        // }

        return sb.ToString();
    }

    public static ListNode New(int[] values)
    {
        var head = new ListNode(values[0]);
        var current = head;
        for (var i = 1; i < values.Length; i++)
        {
            current.next = new ListNode(values[i]);
            current = current.next;
        }
        return head;
    }
}

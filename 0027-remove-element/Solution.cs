namespace _0027_remove_element;

public class Solution
{
    public int RemoveElement(int[] nums, int val)
    {
        var data = nums.AsSpan();

        var count = 0;
        for (var i = 0; i < data.Length; i++)
        {
            if (data[i] == val)
                continue;

            data[count] = data[i];
            count++;
        }

        return count;
    }
}

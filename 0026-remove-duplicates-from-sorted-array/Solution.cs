namespace _0026_remove_duplicates_from_sorted_array;

public class Solution
{
    public int RemoveDuplicates(int[] nums)
    {
        var data = nums.AsSpan();

        var index = 0;
        for (var i = 1; i < data.Length; i++)
            if (data[index] != data[i])
                data[++index] = data[i];

        return ++index;
    }
}

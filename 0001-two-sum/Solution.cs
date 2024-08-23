namespace _0001_two_sum;

public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        var set = new Dictionary<int, int>();
        var data = nums.AsSpan();
        var len = data.Length;
        for (var i = 0; i < len; i++)
        {
            var item = data[i];
            var subtarget = target - item;
            if (set.TryGetValue(subtarget, out var value))
            {
                return [value, i];
            }
            else
            {
                set.TryAdd(item, i);
            }
        }

        return [];
    }
}

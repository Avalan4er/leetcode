namespace _0016_3sum_closest;

public class Solution
{
    public int ThreeSumClosest(int[] nums, int target)
    {
        var data = nums.AsSpan();
        data.Sort((x, y) => x <= y ? 1 : -1);

        var closest = int.MaxValue;
        var start = 0;
        while (start < data.Length - 2)
        {
            var x = data[start];
            int mid = start + 1, end = data.Length - 1;
            while (mid < end)
            {
                int y = data[mid], z = data[end];
                var value = x + y + z;

                if (value == target)
                    return target;
                if (Math.Abs(target - closest) > Math.Abs(target - value))
                {
                    closest = value;
                }
                if (target - value > 0)
                {
                    end--;
                }
                else
                {
                    mid++;
                }
            }

            while (start < data.Length - 2 && data[start] == x)
                start++;
        }

        return closest;
    }
}

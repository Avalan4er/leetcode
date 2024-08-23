namespace _0001_two_sum;

public class Solution1
{
    public int[] TwoSum(int[] nums, int target)
    {
        var dict = nums.Select((x, i) => (i, x)).OrderBy(x => x.x).ToArray().AsSpan();

        var left = 0;
        var right = nums.Length - 1;

        while (left < right)
        {
            var sum = dict[left].x + dict[right].x;
            if (sum == target)
            {
                return [dict[left].i, dict[right].i];
            }
            else if (sum < target)
            {
                left++;
            }
            else if (sum > target)
            {
                right--;
            }
        }

        return [];
    }
}

using Microsoft.Win32.SafeHandles;

namespace _0031_next_permutation;

public class Solution
{
    public void NextPermutation(int[] nums)
    {
        var data = nums.AsSpan();
        var permIdx = GetPermutationIdx(nums);
        if (permIdx == 0)
        {
            Array.Sort(nums);
        }
        else
        {
            var slice = data[permIdx..];
            var minIdx = permIdx + FindNextMin(slice, nums[permIdx - 1]);
            Swap(data, permIdx - 1, minIdx);
            slice.Sort();
        }
    }

    private static int GetPermutationIdx(ReadOnlySpan<int> nums)
    {
        var len = nums.Length;
        for (var i = len - 1; i > 0; i--)
        {
            var current = nums[i];
            var prev = nums[i - 1];

            if (prev < current)
                return i;
        }

        return 0;
    }

    private static int FindNextMin(ReadOnlySpan<int> nums, int lowerLimit)
    {
        var idx = 0;
        var min = nums[idx];
        var len = nums.Length;
        for (var i = 0; i < len; i++)
        {
            var item = nums[i];
            if (item < min && item > lowerLimit)
            {
                min = item;
                idx = i;
            }
        }

        return idx;
    }

    private static void Swap(Span<int> nums, int i, int j)
    {
        (nums[i], nums[j]) = (nums[j], nums[i]);
    }
}

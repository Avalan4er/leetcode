namespace _0004_median_of_two_sorted_arrays;

public class Solution1 {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) 
    {
        var length = nums1.Length + nums2.Length;
        if (length == 0)
            return 0;

        var merged = Merge(nums1, nums2);

        if (merged.Length % 2 == 1)
            return merged[length / 2];
        else
            return 0.5 * (merged[length / 2] + merged[length / 2 - 1]);
    }

    private static int[] Merge(int[] nums1, int[] nums2)
    {
        int i1 = 0, i2 = 0, r = 0;
        int[] result = new int[nums1.Length + nums2.Length];
        while (r < result.Length)
        {
            if (i2 >= nums2.Length || (i1 < nums1.Length && nums1[i1] <= nums2[i2]))
            {
                result[r] = nums1[i1];
                i1++;
            }
            else if (i1 >= nums1.Length || (i2 < nums2.Length && nums1[i1] > nums2[i2]))
            {
                result[r] = nums2[i2];
                i2++;
            }
            r++;
        }

        return result;
    }
}
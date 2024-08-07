namespace _0004_median_of_two_sorted_arrays;

public class Solution2 {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) 
    {
        if ((nums1.Length + nums2.Length) % 2 == 1)
            return GetMiddleElements(nums1, nums2, 1).First();

        var sum = GetMiddleElements(nums1, nums2, 2).Sum();
        return 0.5 * sum;
    }

    private static IEnumerable<int> GetMiddleElements(int[] nums1, int[] nums2, int count)
    {
        int i1 = 0, i2 = 0, r = 0;
        int length = nums1.Length + nums2.Length;
        int begin = length / 2 - count / 2;
        int end = (int)(length / 2 + Math.Ceiling((double)count / 2));
        while (r < end)
        {
            if (i2 >= nums2.Length || (i1 < nums1.Length && nums1[i1] <= nums2[i2]))
            {
                if (r >= begin)
                    yield return nums1[i1];
                i1++;
            }
            else if (i1 >= nums1.Length || (i2 < nums2.Length && nums1[i1] > nums2[i2]))
            {
                if (r >= begin)
                    yield return nums2[i2];
                i2++;
            }
            r++;
        }

    }
}
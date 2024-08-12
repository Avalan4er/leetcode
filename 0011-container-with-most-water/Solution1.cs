namespace _0011_container_with_most_water;

public class Solution1
{
    public int MaxArea(int[] height)
    {
        int largestVolume = 0;

        for (var start = 0; start < height.Length - 1; start++)
        {
            var startHeight = height[start];
            for (var end = start + 1; end < height.Length; end++)
            {
                var endHeight = height[end];
                var volume = Math.Min(startHeight, endHeight) * (end - start);

                if (volume > largestVolume)
                {
                    largestVolume = volume;
                }
            }
        }

        return largestVolume;
    }
}

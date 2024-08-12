using System.ComponentModel.DataAnnotations;

namespace _0011_container_with_most_water;

public class Solution2
{
    public int MaxArea(int[] height)
    {
        var maxHeight = height.Max();
        var maxVolume = 0;
        var data = height.AsSpan();

        var leftIdx = 0;
        var rightIdx = data.Length - 1;
        for (var i = 1; i <= maxHeight; i++)
        {
            for (var j = leftIdx; j < data.Length; j++)
                if (data[j] >= i)
                {
                    leftIdx = j;
                    break;
                }

            for (var j = rightIdx; j > leftIdx; j--)
                if (data[j] >= i)
                {
                    rightIdx = j;
                    break;
                }

            var volume = Math.Min(data[rightIdx], data[leftIdx]) * (rightIdx - leftIdx);
            if (volume > maxVolume)
                maxVolume = volume;

            if (rightIdx - leftIdx == 1)
                return maxVolume;
        }

        return maxVolume;
    }
}

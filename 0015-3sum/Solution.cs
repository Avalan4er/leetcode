using System.Diagnostics.CodeAnalysis;

namespace _0015_3sum;

public class Solution
{
    public IList<IList<int>> ThreeSum(int[] nums)
    {
        var data = nums.AsSpan();
        data.Sort((x, y) => x <= y ? 1 : -1);
        var result = new List<IList<int>>();

        var start = 0;
        while (start < data.Length - 2)
        {
            int middle = start + 1, end = data.Length - 1;
            var x = data[start];
            while (middle < end)
            {
                int y = data[middle], z = data[end];
                if (x + y + z == 0)
                {
                    result.Add([x, y, z]);

                    while (middle < end && data[middle] == y)
                        middle++;
                    while (middle < end && data[end] == z)
                        end--;
                }
                else if (x + y + z > 0)
                {
                    middle++;
                }
                else if (x + y + z < 0)
                {
                    end--;
                }
            }

            while (start < data.Length - 1 && data[start] == x)
                start++;
        }

        return result;
    }
}

public class IListComparer : IEqualityComparer<IList<int>>
{
    public bool Equals(IList<int>? x, IList<int>? y)
    {
        if (x is null || y is null)
            return false;

        return x.SequenceEqual(y);
    }

    public int GetHashCode([DisallowNull] IList<int> obj)
    {
        return obj[0] * 10512 +
            obj[1] * 10512 +
            obj[2] * 10512;
    }
}

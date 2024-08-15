using Xunit.Sdk;

namespace _0018_4sum;

public class Solution
{
    public IList<IList<int>> FourSum(int[] nums, int target)
    {
        var data = nums.AsSpan();
        data.Sort((x, y) => x > y ? -1 : 1);
        var one = 0;

        var result = new List<IList<int>>();
        while (one < data.Length - 3)
        {
            var x = data[one];

            var four = data.Length - 1;
            while (four > one + 2)
            {
                var u = data[four];
                var two = one + 1;
                var three = four - 1;

                while (three > two)
                {
                    var y = data[two];
                    var z = data[three];

                    var value = (long)x + y + z + u;
                    if (value == target)
                    {
                        result.Add([x, y, z, u]);

                        while (three > two && data[two] == y)
                            two++;
                        while (three > two && data[three] == z)
                            three--;
                    }
                    else if (value > target)
                    {
                        two++;
                    }
                    else if (value < target)
                    {
                        three--;
                    }
                }

                while (four > one + 2 && data[four] == u)
                    four--;
            }

            while (one < data.Length - 3 && data[one] == x)
                one++;
        }

        return result;
    }
}

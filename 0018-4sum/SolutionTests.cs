using System.Diagnostics.CodeAnalysis;

namespace _0018_4sum;

public class SolutionTests
{
    [Fact]
    public void Case1()
    {
        var sln = new Solution();

        var result = sln.FourSum([1, 0, -1, 0, -2, 2], 0);

        Assert.True(result.SequenceEqual([[2, 1, -1, -2], [2, 0, 0, -2], [1, 0, 0, -1]], new IListComparer()));
    }

    [Fact]
    public void Case2()
    {
        var sln = new Solution();

        var result = sln.FourSum([2, 2, 2, 2, 2], 8);

        Assert.True(result.SequenceEqual([[2, 2, 2, 2]], new IListComparer()));
    }

    [Fact]
    public void Case3()
    {
        var sln = new Solution();

        var result = sln.FourSum([1000000000, 1000000000, 1000000000, 1000000000], -294967296);

        Assert.True(result.SequenceEqual([], new IListComparer()));
    }

    class IListComparer : IEqualityComparer<IList<int>>
    {
        public bool Equals(IList<int>? x, IList<int>? y)
        {
            if (x is null || y is null)
                return false;

            return x.SequenceEqual(y);
        }

        public int GetHashCode([DisallowNull] IList<int> obj)
        {
            return obj[0] * 12512836
                + obj[1] * 12512836
                + obj[2] * 12512836
                + obj[3] * 12512836;
        }
    }
}

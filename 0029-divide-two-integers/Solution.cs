namespace _0029_divide_two_integers;

public class Solution
{
    public int Divide(int dividend, int divisor)
    {
        if (dividend == divisor)
            return 1;

        var isPositive = dividend < 0 == divisor < 0;
        uint a = dividend < 0 ? uint.MaxValue - (uint)dividend + 1 : (uint)dividend;
        uint b = divisor < 0 ? uint.MaxValue - (uint)divisor + 1 : (uint)divisor;

        uint quotient = 0;
        while (a >= b)
        {
            ushort c = 0;
            while (a > (b << (c + 1)))
                c++;

            quotient += (uint)1 << c;
            a -= b << c;
        }

        if (quotient >= int.MaxValue && isPositive)
            return int.MaxValue;

        return isPositive ? (int)quotient : -(int)quotient;
    }
}

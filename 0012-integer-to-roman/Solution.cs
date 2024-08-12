using System.Text;

namespace _0012_integer_to_roman;

public class Solution
{
    public string IntToRoman(int num)
    {
        return IntToRoman(num, 10);
    }

    private string IntToRoman(int num, int pos)
    {
        var digit = num % pos;

        var t = digit;
        var sb = new StringBuilder();
        if (num * 10 >= pos * 10)
            sb.Append(IntToRoman(num - digit, pos * 10));

        while (t > 0)
        {
            var sub = t switch
            {
                >= 1000 => 1000,
                900 => 900,
                >= 500 => 500,
                400 => 400,
                >= 100 => 100,
                90 => 90,
                >= 50 => 50,
                40 => 40,
                >= 10 => 10,
                9 => 9,
                >= 5 => 5,
                4 => 4,
                >= 1 => 1,
                _ => throw new Exception()
            };

            t -= sub;
            sb.Append(sub switch
            {
                1000 => 'M',
                900 => "CM",
                500 => 'D',
                400 => "CD",
                100 => 'C',
                90 => "XC",
                50 => 'L',
                40 => "XL",
                10 => 'X',
                9 => "IX",
                5 => 'V',
                4 => "IV",
                1 => 'I',
                _ => throw new Exception()
            });
        }

        return sb.ToString();
    }
}

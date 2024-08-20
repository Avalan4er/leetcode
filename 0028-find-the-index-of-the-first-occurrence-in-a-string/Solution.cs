namespace _0028_find_the_index_of_the_first_occurrence_in_a_string;

public class Solution
{
    public int StrStr(string haystack, string needle)
    {
        var data = haystack.AsSpan();
        var dataLength = data.Length;
        var keyword = needle.AsSpan();
        var keywordLength = keyword.Length;

        var result = -1;
        for (var i = 0; i < dataLength; i++)
        {
            if (keyword[0] == data[i])
            {
                result = i;
                for (var j = 0; j < keywordLength && i + j < dataLength; j++)
                {
                    if (keyword[j] != data[i + j])
                        break;

                    if (j == keywordLength - 1)
                        return result;
                }
                result = -1;
            }
        }

        return result;
    }
}

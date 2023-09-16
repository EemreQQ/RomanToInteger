public class Solution
{
    public int RomanToInt(string s)
    {
        Dictionary<char, int> keyValuePairs = new Dictionary<char, int>();
        keyValuePairs['I'] = 1;
        keyValuePairs['V'] = 5;
        keyValuePairs['X'] = 10;
        keyValuePairs['L'] = 50;
        keyValuePairs['C'] = 100;
        keyValuePairs['D'] = 500;
        keyValuePairs['M'] = 1000;
        int total = 0;
        if (s.Length < 2)
            return keyValuePairs[s[0]];
        else
            for (int i = 0; i < s.Length; i++)
            {
                if (s.Length - 1 > i && keyValuePairs[s[i + 1]] > keyValuePairs[s[i]])
                {
                    total += keyValuePairs[s[i + 1]] - keyValuePairs[s[i]];
                    i++;
                }
                else
                    total += keyValuePairs[s[i]];
            }
        return total;
    }
}
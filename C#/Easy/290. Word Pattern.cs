public class Solution {
    public bool WordPattern(string pattern, string s) {
        Dictionary<char, string> dict = new Dictionary<char, string>();

        Dictionary<string, char> dictF = new Dictionary<string, char>();

        string[] sArray = s.Split(" ");

        if (sArray.Length != pattern.Length)
        {
            return false;
        }

        for (int i = 0; i < pattern.Length; i++)
        {
            if (dict.ContainsKey(pattern[i]))
            {
                if (dict[pattern[i]] != sArray[i])
                {
                    return false;
                }
            }

            else
            {
                dict.Add(pattern[i], sArray[i]);
            }

            if (dictF.ContainsKey(sArray[i]))
            {
                if (dictF[sArray[i]] != pattern[i])
                {
                    return false;
                }
            }

            else
            {
                dictF.Add(sArray[i], pattern[i]);
            }
        }

        return true;
    }
}
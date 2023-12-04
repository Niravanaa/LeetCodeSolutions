using System;
using System.Collections.Generic;
using System.Text;

public class Solution
{
    public string SortVowels(string s)
    {
        List<char> vowels = new List<char>();
        List<char> consonants = new List<char>();

        foreach (char c in s)
        {
            if ("aeiouAEIOU".IndexOf(c) >= 0)
            {
                vowels.Add(c);
            }
            else
            {
                consonants.Add(c);
            }
        }

        vowels.Sort();

        StringBuilder result = new StringBuilder();
        int vowelIndex = 0;
        int consonantIndex = 0;

        foreach (char c in s)
        {
            if ("aeiouAEIOU".IndexOf(c) >= 0)
            {
                result.Append(vowels[vowelIndex++]);
            }
            else
            {
                result.Append(consonants[consonantIndex++]);
            }
        }

        return result.ToString();
    }
}


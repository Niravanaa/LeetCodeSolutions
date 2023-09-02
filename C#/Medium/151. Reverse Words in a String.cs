using System;  
using System.Text.RegularExpressions;  
using System.Collections.Generic;  

public class Solution {
    public string ReverseWords(string s) {
        string[] words = Regex.Split(s.Trim(), " +");

        Array.Reverse(words);

        string result = "";

        foreach (string word in words)
        {
            result += word.Trim() + " ";
        }

        return result.Trim();
    }
}
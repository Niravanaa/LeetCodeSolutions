using System.Text.RegularExpressions;

public class Solution {
    public bool IsPalindrome(string s) {
        s = Regex.Replace(s, "[^A-Za-z0-9]", "");
        s = Regex.Replace(s, " ", "");
        s = s.ToLower();

        char[] stringArray = s.ToCharArray();

        Array.Reverse(stringArray);

        string reversedString = new string(stringArray);

        if (s == reversedString) {
            return true;
        }

        return false;
    }
}
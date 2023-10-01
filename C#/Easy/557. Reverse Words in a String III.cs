public class Solution {
    public string ReverseWords(string s) {
        string[] words = s.Split(" ");

        string result = "";

        foreach (string word in words)
        {
            char[] stringArray = word.ToCharArray();

            Array.Reverse(stringArray);

            string reversedStr = new string(stringArray);

            result += reversedStr + " ";
        }

        return result.Trim();
    }
}
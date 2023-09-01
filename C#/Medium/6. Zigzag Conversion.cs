public class Solution {
    public string Convert(string s, int numRows) {
        if (numRows == 1 || numRows >= s.Length)
            return s;

        StringBuilder result = new StringBuilder();
        int step = numRows * 2 - 2;

        for (int i = 0; i < numRows; i++) {
            for (int j = i; j < s.Length; j += step) {
                result.Append(s[j]);
                if (i > 0 && i < numRows - 1 && j + step - 2 * i < s.Length) {
                    result.Append(s[j + step - 2 * i]);
                }
            }
        }

        return result.ToString();
    }
}

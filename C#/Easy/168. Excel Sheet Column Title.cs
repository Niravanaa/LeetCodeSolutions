public class Solution {
    public string ConvertToTitle(int columnNumber) {
        StringBuilder result = new StringBuilder();

        while (columnNumber > 0) {
            columnNumber--; // Adjust to 0-based indexing

            int remainder = columnNumber % 26;

            char titleChar = (char)('A' + remainder);

            result.Insert(0, titleChar); // Insert the character at the beginning
            
            columnNumber /= 26;
        }

        return result.ToString();
    }
}

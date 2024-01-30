public class Solution {
    public int TitleToNumber(string columnTitle) {
        if (columnTitle.Length == 0 || columnTitle == null)
        {
            return -1;
        }

        columnTitle = columnTitle.ToUpperInvariant();

        int sum = 0;

        for (int i = 0; i < columnTitle.Length; i++)
        {
            sum *= 26;

            sum += (columnTitle[i] - 'A' + 1);
        }

        return sum;
    }
}
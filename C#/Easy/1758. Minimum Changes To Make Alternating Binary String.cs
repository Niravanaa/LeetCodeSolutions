public class Solution 
{
    public int MinOperations(string s) 
    {
        int firstZero = 0;
        int secondOne = 0;

        int firstOne = 0;
        int secondZero = 0;

        for (int i = 0; i < s.Length; i += 2)
        {
            if (s[i] == '0') {
                firstOne++;
            } else {
                firstZero++;
            }
        }

        for (int i = 1; i < s.Length; i += 2)
        {
            if (s[i] == '0') {
                secondOne++;
            } else {
                secondZero++;
            }
        }

        return Math.Min(firstZero + secondOne, firstOne + secondZero);
    }
}
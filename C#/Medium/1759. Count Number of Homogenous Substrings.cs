public class Solution {
    public int CountHomogenous(string s) {
        int firstPointer = 0;

        int secondPointer = 1;

        int result = 0;

        int difference = 0;

        while (secondPointer < s.Length)
        {
            if (s[secondPointer] == s[firstPointer])
            {
                secondPointer++;
            }

            else
            {
                difference = secondPointer - firstPointer;

                result += (int)((long)difference * (difference + 1) / 2 % 1000000007);

                firstPointer = secondPointer;

                secondPointer++;
            }
        }

        difference = secondPointer - firstPointer;

        result += (int)((long)difference * (difference + 1) / 2 % 1000000007);
    
        return result;
    }
}
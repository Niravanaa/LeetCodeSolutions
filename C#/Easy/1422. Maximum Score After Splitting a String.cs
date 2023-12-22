public class Solution {
    public int MaxScore(string s) {
        int zerosToLeft = 0;
        int onesToRight = s.Count(c => c == '1');
        int maxScore = 0;

        for (int i = 0; i < s.Length - 1; i++) {
            if (s[i] == '0') {
                zerosToLeft++;
            } else {
                onesToRight--;
                
            int currentScore = zerosToLeft + onesToRight;
            maxScore = Math.Max(maxScore, currentScore);
        }

        return maxScore;
    }
}
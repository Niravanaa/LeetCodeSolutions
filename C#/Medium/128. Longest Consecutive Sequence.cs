public class Solution {
    public int LongestConsecutive(int[] nums) {
        if (nums.Length == 0)
        {
            return 0;
        }

        HashSet<int> consecutives = new HashSet<int>(nums);

        int longest_streak = 0;
        

        foreach (int num in consecutives)
        {
            if (!consecutives.Contains(num - 1))
            {
                int current_number = num;

                int current_streak = 1;

                while (consecutives.Contains(current_number + 1))
                {
                    current_number++;
                    current_streak++;
                }

                longest_streak = Math.Max(longest_streak, current_streak);
            }
        }

        return longest_streak;
    }
}
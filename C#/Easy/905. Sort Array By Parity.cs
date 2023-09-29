public class Solution {
    public int[] SortArrayByParity(int[] nums) {
        List<int> evens = new List<int>();

        List<int> odds = new List<int>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] % 2 == 0)
            {
                evens.Add(nums[i]);
            }

            else
            {
                odds.Add(nums[i]);
            }
        }

        int[] evensArray = evens.ToArray();

        int[] oddsArray = odds.ToArray();

        int[] result = new int[evensArray.Length + oddsArray.Length];

        for (int i = 0; i < evensArray.Length; i++)
        {
            result[i] = evensArray[i];
        }

        for (int i = evensArray.Length; i < oddsArray.Length + evensArray.Length; i++)
        {
            result[i] = oddsArray[i - evensArray.Length];
        }

        return result;
    }
}
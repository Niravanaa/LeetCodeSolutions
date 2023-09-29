public class Solution {
    public bool IsMonotonic(int[] nums) {
        int[] copy = new int[nums.Length];

        for (int i = 0; i < copy.Length; i++)
        {
            copy[i] = nums[i];
        }

        Array.Sort(copy);

        bool forwardSorted = true;

        for (int i = 0; i < copy.Length; i++)
        {
            if (copy[i] != nums[i])
            {
                forwardSorted = false;
            }
        }

        if (forwardSorted)
        {
            return true;
        }

        Array.Reverse(copy);

        bool backwardSorted = true;

        for (int i = 0; i < copy.Length; i++)
        {
            if (copy[i] != nums[i])
            {
                backwardSorted = false;
            }
        }

        if (backwardSorted)
        {
            return true;
        }

        return false;
    }
}
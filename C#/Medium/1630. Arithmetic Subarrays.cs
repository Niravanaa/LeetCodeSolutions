public class Solution {
    public IList<bool> CheckArithmeticSubarrays(int[] nums, int[] l, int[] r) {
        List<bool> result = new List<bool>();

        for (int i = 0; i < l.Length; i++)
        {
            int left = l[i];
            
            int right = r[i];

            int[] subArray = new int[right - left + 1];

            Array.Copy(nums, left, subArray, 0, right - left + 1);

            Array.Sort(subArray);

            bool isArithmetic = true;

            int diff = subArray[1] - subArray[0];

            for (int j = 1; j < subArray.Length - 1; j++)
            {
                if (diff != subArray[j + 1] - subArray[j])
                {
                    isArithmetic = false;
                    break;
                }
            }

            result.Add(isArithmetic);
        }

        return result;
    }
}
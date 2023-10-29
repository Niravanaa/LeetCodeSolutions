public class Solution {
    public int[] CountBits(int n) {
        int[] result = new int[n + 1];

        for (int i = 0; i < result.Length; i++)
        {
            string binaryNumberString = Convert.ToString(i, 2);

            result[i] = binaryNumberString.Split('1').Length - 1;
        }

        return result;
    }
}
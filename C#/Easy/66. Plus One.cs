public class Solution {
    public int[] PlusOne(int[] digits) {
        int carry = 1;
        List < int > result = new List < int > ();

        for (int i = digits.Length - 1; i >= 0; i--) {
            int sum = digits[i] + carry;
            result.Add(sum % 10);
            carry = sum / 10;
        }

        if (carry > 0) {
            result.Add(carry);
        }

        result.Reverse();

        return result.ToArray();
    }
}
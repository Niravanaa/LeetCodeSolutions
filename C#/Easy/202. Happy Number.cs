public class Solution {
    public int squareSum(int n)
    {
        int squareSum = 0;

        while (n != 0)
        {
            squareSum += (n % 10) * (n % 10);

            n /= 10;
        }

        return squareSum;
    }

    public bool IsHappy(int n)
    {
        HashSet<int> numbers = new HashSet<int>();

        while (true)
        {
            n = squareSum(n);

            if (n == 1)
            {
                return true;
            }

            if (numbers.Contains(n))
            {
                return false;
            }

            numbers.Add(n);
        }
    }
}
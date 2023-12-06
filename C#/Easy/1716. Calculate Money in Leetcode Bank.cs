public class Solution {
    public int TotalMoney(int n) 
    {
        int weeks = n / 7;

        int leftOverDays = n % 7;

        int total = 0;

        for (int i = 0; i < weeks; i++)
        {
            total += 28 + 7 * i;
        }

        int currentMoney = weeks + 1;

        for (int i = 0; i < leftOverDays; i++)
        {
            total += currentMoney;
            currentMoney++;
        }

        return total;
    }
}
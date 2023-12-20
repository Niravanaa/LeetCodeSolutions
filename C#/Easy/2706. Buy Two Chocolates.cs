public class Solution {
    public int BuyChoco(int[] prices, int money) {
        quickSort(prices, 0, prices.Length - 1);

        return money - (prices[1] + prices[0]) >= 0 ? money - (prices[1] + prices[0]) : money;
    }

    private int[] quickSort(int[] array, int left, int right)
    {
        int i = left;
        int j = right;
        int pivot = array[i];

        while (i <= j)
        {
            while (array[i] < pivot)
            {
                i++;
            }

            while (array[j] > pivot)
            {
                j--;
            }

            if (i <= j)
            {
                int temp = array[i];
                array[i] = array[j];
                array[j] = temp;
                i++;
                j--;
            }
        }

        if (left < j)
        {
            quickSort(array, left, j);
        }

        if (i < right)
        {
            quickSort(array, i, right);
        }
        
        return array;
    }
}
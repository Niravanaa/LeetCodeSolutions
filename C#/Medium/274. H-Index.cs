public class Solution {
    public int HIndex(int[] citations) {
        int publishedNumber = citations.Max();

        int citedNumber = -1;

        while (publishedNumber > 0)
        {
            citedNumber = 0;

            for (int i = 0; i < citations.Length; i++)
            {
                if (publishedNumber <= citations[i])
                {
                    citedNumber++;
                }
            }

            if (citedNumber >= publishedNumber)
            {
                return publishedNumber;
            }

            publishedNumber--;
        }

        return 0;
    }
}
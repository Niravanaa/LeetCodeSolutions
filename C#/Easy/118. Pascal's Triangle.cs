public class Solution {
    public IList<IList<int>> Generate(int numRows) {
        int c = 1;

        IList<IList<int>> result = new List<IList<int>>();

        for (int i = 0; i < numRows; i++)
        {
            IList<int> currentList = new List<int>();

            for (int j = 0; j <= i; j++)
            {
                if (j == 0 || i == 0)
                {
                    c = 1;
                }

                else
                {
                    c = c * (i - j + 1) / j;
                }

                currentList.Add(c);
            }

            result.Add(currentList);
        }

        return result;
    }
}
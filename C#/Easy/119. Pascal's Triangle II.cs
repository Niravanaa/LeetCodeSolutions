public class Solution {
    public IList<int> GetRow(int rowIndex) {
        List<int> result = new List<int>();

        if (rowIndex == 0)
        {
            result.Add(1);
            
            return result;
        }

        if (rowIndex == 1)
        {
            result.Add(1);

            result.Add(1);

            return result;
        }

        double c = 1;

        for (int i = 0; i <= rowIndex; i++)
        {
            if (i == 0 || i == rowIndex)
            {
                result.Add(1);
            }

            else
            {
                c = c * (rowIndex - i + 1) / i;

                result.Add((int)c);
            }
        }

        return result;
    }
}
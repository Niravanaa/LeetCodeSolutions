public class Solution {
    public int[] FindDiagonalOrder(IList<IList<int>> nums) {
        Dictionary<int, List<int>> groups = new Dictionary<int, List<int>>();

        for (int row = nums.Count - 1; row >= 0; row--)
        {
            for (int col = 0; col < nums[row].Count; col++)
            {
                int diagonal = row + col;

                if (!groups.ContainsKey(diagonal))
                {
                    groups[diagonal] = new List<int>();
                }

                groups[diagonal].Add(nums[row][col]);
            }
        }

        List<int> result = new List<int>();

        int current = 0;

        while (groups.ContainsKey(current))
        {
            result.AddRange(groups[current]);

            current++;
        }

        return result.ToArray();
    }
}
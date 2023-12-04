public class Solution {
    public IList<string> BuildArray(int[] target, int n) {
        var result = new List<string>();

        int i = 1;

        foreach (int t in target)
        {
            while (i < t)
            {
                result.Add("Push");

                result.Add("Pop");
                
                i++;
            }

            result.Add("Push");

            i++;
        }

        return result;
    }
}
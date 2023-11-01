public class Solution {
    public int[] FindMode(TreeNode root) {
        int[] result = new int[1];

        List<int> values = new List<int>();

        Queue<TreeNode> queue = new Queue<TreeNode>();

        queue.Enqueue(root);

        while (queue.Count > 0)
        {
            TreeNode current = queue.Dequeue();

            values.Add(current.val);

            if (current.left != null)
                queue.Enqueue(current.left);

            if (current.right != null)
                queue.Enqueue(current.right);
        }

        Dictionary<int, int> frequencyMap = new Dictionary<int, int>();

        foreach (int number in values)
        {
            if (frequencyMap.ContainsKey(number))
            {
                frequencyMap[number]++;
            }
            else
            {
                frequencyMap[number] = 1;
            }
        }

        int maxFrequency = frequencyMap.Values.Max();

        List<int> modes = frequencyMap.Where(pair => pair.Value == maxFrequency).Select(pair => pair.Key).ToList();

        return modes.ToArray();
    }
}
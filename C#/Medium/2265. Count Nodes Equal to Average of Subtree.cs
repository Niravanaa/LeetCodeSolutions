/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public int AverageOfSubtree(TreeNode root)
    {
        if (root == null)
            return 0;

        int count = 0;

        Queue<TreeNode> queue = new Queue<TreeNode>();

        queue.Enqueue(root);

        while (queue.Count > 0)
        {
            TreeNode node = queue.Dequeue();

            if (IsSubtreeAverageEqual(node))
                count++;

            if (node.left != null)
                queue.Enqueue(node.left);

            if (node.right != null)
                queue.Enqueue(node.right);
        }

        return count;
    }

    private bool IsSubtreeAverageEqual(TreeNode node)
    {
        if (node == null)
            return false;

        int subtreeSum = 0;

        int subtreeSize = 0;

        Queue<TreeNode> subtreeQueue = new Queue<TreeNode>();

        subtreeQueue.Enqueue(node);

        while (subtreeQueue.Count > 0)
        {
            TreeNode subtreeNode = subtreeQueue.Dequeue();

            subtreeSum += subtreeNode.val;

            subtreeSize++;

            if (subtreeNode.left != null)
                subtreeQueue.Enqueue(subtreeNode.left);

            if (subtreeNode.right != null)
                subtreeQueue.Enqueue(subtreeNode.right);
        }

        return (node.val == subtreeSum / subtreeSize);
    }
}
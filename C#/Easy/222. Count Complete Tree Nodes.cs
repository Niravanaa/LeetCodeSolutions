
public class Solution {
    public int CountNodes(TreeNode root) {
        if (root == null)
        {
            return 0;
        }

        int leftHeight = GetHeight(root.left);
        int rightHeight = GetHeight(root.right);

        if (leftHeight == rightHeight)
        {
            // The left subtree is a perfect binary tree.
            // The last node may exist in the right subtree.
            return (1 << leftHeight) + CountNodes(root.right);
        }
        else
        {
            // The right subtree is a perfect binary tree.
            // The last node must exist in the left subtree.
            return (1 << rightHeight) + CountNodes(root.left);
        }
    }

    private int GetHeight(TreeNode node)
    {
        int height = 0;
        while (node != null)
        {
            height++;
            node = node.left;
        }
        return height;
    }
}

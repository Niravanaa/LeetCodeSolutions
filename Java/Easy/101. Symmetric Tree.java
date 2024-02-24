class Solution {
    public boolean isSymmetric(TreeNode root) {
        return isMirror(root, root);
    }

    private boolean isMirror(TreeNode root1, TreeNode root2)
    {
        if (root1 == null && root2 == null)
        {
            return true;
        }

        if (root1 != null && root2 != null && root1.val == root2.val)
        {
            return (isMirror(root1.left, root2.right) && isMirror(root2.right, root1.left));
        }

        return false;
    }
}
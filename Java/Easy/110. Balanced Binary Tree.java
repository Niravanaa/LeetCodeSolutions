class Solution {
    public boolean isBalanced(TreeNode root) {
        if (root == null) return true;

        int leftHeight = height(root.left);

        int rightHeight = height(root.right);

        if (Math.abs(leftHeight - rightHeight) <= 1 && isBalanced(root.left) && isBalanced(root.right)) return true;

        return false;
    }

    private int height(TreeNode root) {
        if (root == null) return 0;

        return 1 + Math.max(height(root.left), height(root.right));
    }
}
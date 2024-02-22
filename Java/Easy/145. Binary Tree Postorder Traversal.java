class Solution {
    public List<Integer> postorderTraversal(TreeNode root) {
        List<Integer> result = new ArrayList<>();
        Stack<TreeNode> stack = new Stack<>();
        TreeNode prev = null;

        while (root != null || !stack.isEmpty()) {
            while (root != null) {
                stack.push(root);
                root = root.left;
            }

            TreeNode current = stack.peek();

            if (current.right == null || current.right == prev) {
                result.add(current.val);
                stack.pop();
                prev = current;
            } else {
                root = current.right;
            }
        }

        return result;
    }
}
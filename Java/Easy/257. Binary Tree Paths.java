class Solution {
    public List<String> binaryTreePaths(TreeNode root) {
        List<String> result = new ArrayList<>();
        if (root == null) {
            return result;
        }
        traverse(root, "", result);
        return result;
    }
    
    private void traverse(TreeNode node, String path, List<String> result) {
        if (node.left == null && node.right == null) {
            result.add(path + node.val);
            return;
        }
        
        if (node.left != null) {
            traverse(node.left, path + node.val + "->", result);
        }
        
        if (node.right != null) {
            traverse(node.right, path + node.val + "->", result);
        }
    }
}

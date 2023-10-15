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
 */
public class Solution {
    // Helper function to convert a binary tree to an array
    public int[] BinaryTreeToArray(TreeNode root)
    {
        List<int> result = new List<int>();

        // Recursive function to traverse the binary tree
        if (root != null)
        {
            result.Add(root.val); // Add the current node's value to the list

            // Recursively process the left subtree, if it exists
            if (root.left != null)
            {
                result.AddRange(BinaryTreeToArray(root.left));
            }

            // Recursively process the right subtree, if it exists
            if (root.right != null)
            {
                result.AddRange(BinaryTreeToArray(root.right));
            }
        }

        return result.ToArray(); // Convert the list to an array and return it
    }

    // Function to find the minimum absolute difference between any two values in the binary tree
    public int GetMinimumDifference(TreeNode root) {

        // Convert the binary tree to an array using the helper function
        int[] resultArray = BinaryTreeToArray(root);

        // Sort the array to have values in ascending order
        Array.Sort(resultArray);

        int minimum = Int32.MaxValue; // Initialize a variable to track the minimum difference

        // Iterate through the sorted array to find the minimum difference
        for (int i = 0; i < resultArray.Length - 1; i++)
        {
            if (resultArray[i+1] - resultArray[i] < minimum)
            {
                minimum = resultArray[i+1] - resultArray[i]; // Update the minimum difference
            }
        }

        return minimum; // Return the minimum difference
    }
}

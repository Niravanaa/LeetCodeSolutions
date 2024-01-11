/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB) {
        List<ListNode> nodesA = new List<ListNode>();

        ListNode currentNode = headA;

        while (currentNode != null)
        {
            nodesA.Add(currentNode);

            currentNode = currentNode.next;
        }

        currentNode = headB;

        while (currentNode != null)
        {
            if (nodesA.Contains(currentNode))
            {
                return currentNode;
            }

            currentNode = currentNode.next;
        }

        return null;
    }
}
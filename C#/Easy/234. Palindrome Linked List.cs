
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public bool IsPalindrome(ListNode head) {
        if (head == null || head.next == null)
        {
            return true;
        }

        ListNode slow = head;
        ListNode fast = head;

        while (fast.next != null && fast.next.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;
        }

        ListNode secondHalf = reverseList(slow.next);

        while (secondHalf != null)
        {
            if (head.val != secondHalf.val)
            {
                return false;
            }

            head = head.next;
            secondHalf = secondHalf.next;
        }

        return true;
    }

    private ListNode reverseList(ListNode head)
    {
        ListNode current = head;
        ListNode prev = null;
        ListNode next = null;

        while (current != null)
        {
            next = current.next;
            current.next = prev;
            prev = current;
            current = next;
        }

        return prev;
    }
}
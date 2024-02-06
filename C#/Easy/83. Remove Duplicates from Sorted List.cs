public class Solution {
    public ListNode DeleteDuplicates(ListNode head) {
        if (head == null || head.next == null) return head;

        HashSet<int> valuesFound = new HashSet<int>();
        ListNode current = head;
        ListNode previous = null;

        while (current != null)
        {
            if (valuesFound.Contains(current.val))
            {
                previous.next = current.next;
            }
            else
            {
                valuesFound.Add(current.val);
                previous = current;
            }
            current = current.next;
        }
        
        return head;
    }
}
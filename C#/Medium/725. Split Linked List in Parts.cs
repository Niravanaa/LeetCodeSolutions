public class Solution {
    public ListNode[] SplitListToParts(ListNode head, int k) {
        ListNode[] result = new ListNode[k];

        // Calculate the length of the linked list.
        int numberOfNodes = 0;
        ListNode current = head;
        while (current != null) {
            numberOfNodes++;
            current = current.next;
        }

        // Calculate the base length of each part and the remaining nodes.
        int baseLength = numberOfNodes / k;
        int remainingNodes = numberOfNodes % k;

        current = head;
        for (int i = 0; i < k; i++) {
            ListNode partHead = new ListNode(); // Create a dummy node as the head of the current part
            ListNode partCurrent = partHead;

            int partLength = baseLength + (remainingNodes-- > 0 ? 1 : 0);

            for (int j = 0; j < partLength; j++) {
                if (current != null) {
                    partCurrent.next = new ListNode(current.val);
                    partCurrent = partCurrent.next;
                    current = current.next;
                }
            }

            result[i] = partHead.next; // Skip the dummy node in the result
        }

        return result;
    }
}

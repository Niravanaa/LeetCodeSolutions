public class Solution 
{
    public ListNode RemoveNodes(ListNode head) 
    {
        if(head.next == null) return head;

        var temp = RemoveNodes(head.next);

        if(head.val >= temp.val) 
        {
            head.next = temp;

            return head;
        }

        return temp; 
    }
}
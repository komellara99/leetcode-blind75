public class ReverseListSolution {
    public ListNode ReverseList(ListNode head) {
        if(head == null || head.next == null) return head;

        ListNode prev = null;
        ListNode curr = head;
        ListNode next = curr.next;
        
        while(curr.next != null){
            curr.next = prev;
            prev = curr;
            curr = next;
            next = curr.next;
        }
        curr.next = prev;
        return curr;
        
    }
}
/*
 * Given the head of a singly linked list, reverse the list, and return the reversed list.
 */
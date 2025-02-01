public class ReverseBetweenSolution {
    public ListNode ReverseBetween(ListNode head, int left, int right) {
        if(head == null || head.next == null || left == right) return head;

        ListNode prev = null;
        ListNode curr = head;
        ListNode next = curr.next;
        ListNode first = head;
        ListNode last = null;
        int indx = 1;
        
        while(indx <= right){
            if(indx+1 == left) last = curr;
            if(indx == left) first = curr;
            if(indx == right) {
                if (last != null) last.next = curr;
                else last = curr;
                first.next = curr.next;
            }

            if(indx >= left && indx <= right){
                curr.next = prev;
                prev = curr;
                curr = next;
            }else{
                prev = curr;
                curr = curr.next;
            }
            if(curr != null) next = curr.next;
            indx++;
        }
        return (left == 1) ? last : head;
    }
}

/*
 * Given the head of a singly linked list and two integers left and right where left <= right, reverse the nodes of the list from position left to position right, and return the reversed list.
 */
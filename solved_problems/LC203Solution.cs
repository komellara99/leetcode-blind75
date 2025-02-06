
public class RemoveElementsSolution {
    public ListNode RemoveElements(ListNode head, int val) {
        ListNode prev = null;
        ListNode curr = head;
        while(true){
            if(curr == null) return head;
            if(curr.val == val){
                if(prev != null) {
                    prev.next = curr.next;
                }
                else {
                    head = head.next;
                    prev = null;
                }
            }else{
                prev = curr;
            }
            curr = curr.next;
        }
        return head;
    }
}
/*
 * Given the head of a linked list and an integer val, remove all the nodes of the linked list that has Node.val == val, and return the new head.
 */
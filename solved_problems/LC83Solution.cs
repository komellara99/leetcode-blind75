public class DeleteDuplicatesSolution {
    public ListNode DeleteDuplicates(ListNode head) {

        if (head == null || head.next == null) return head;

        if(head.val == head.next.val) {
            while (head.next != null && head.val == head.next.val) {
                head = head.next;
            }
        }
        head.next = DeleteDuplicates(head.next);

        return head;
    }
}

/*
 * Given the head of a sorted linked list, delete all duplicates such that each element appears only once. Return the linked list sorted as well.
 */
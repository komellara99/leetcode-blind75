
  public class ListNode {
      public int val;
      public ListNode next;
      public ListNode(int val=0, ListNode next=null) {
          this.val = val;
          this.next = next;
      }
 }

public class MergeTwoListsSolution {
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        if(list1==null)return list2;
        if(list2==null)return list1;
        var result = list1;
        if(list1.val > list2.val){
            result = list2;
            result.next = MergeTwoLists(list1, list2.next);
        }else{
            result = list1;
            result.next = MergeTwoLists(list1.next, list2);
        }
        return result;
    }
}
/*
 * you are given the heads of two sorted linked lists list1 and list2.
   
   Merge the two lists into one sorted list. The list should be made by splicing together the nodes of the first two lists.
   
   Return the head of the merged linked list.
   
   
 */
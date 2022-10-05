/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     int val;
 *     ListNode next;
 *     ListNode() {}
 *     ListNode(int val) { this.val = val; }
 *     ListNode(int val, ListNode next) { this.val = val; this.next = next; }
 * }
 */
class Solution {
    public ListNode addTwoNumbers(ListNode l1, ListNode l2) {
        
        
        ListNode curr1 = l1;
ListNode curr2 = l2;


int carry = 0;
ListNode lastNode = null;

while(curr1 != null && curr2!= null){

         lastNode = curr1;
         int num1 = curr1.val;
         int num2 = curr2.val;

         int sum = num1 + num2 + carry;
         int tempVal = sum;
         if(sum > 9){
             tempVal = sum % 10;
             carry = sum/10;

         }else{
             carry = 0;

          }
         curr1.val = tempVal;
         curr2.val = tempVal;

         curr1 = curr1.next;
         curr2 = curr2.next;

  }
  ListNode newHead = l1;
  
  while(curr1 != null){
      lastNode = curr1;
      int sum = curr1.val + carry;
      int tempVal = sum;
       if(sum > 9){
             tempVal = sum % 10;
             carry = sum/10;

         }else{
             carry = 0;

          }
       curr1.val = tempVal;
       curr1 = curr1.next;

    }

while(curr2 != null){
    lastNode = curr2;
     newHead = l2;
     int sum = curr2.val + carry;
      int tempVal = sum;
       if(sum > 9){
             tempVal = sum % 10;
             carry = sum/10;

         }else{
             carry = 0;

          }
       curr2.val = tempVal;
       curr2 = curr2.next;


   }
        if(carry > 0){
            ListNode l = new ListNode(carry);
            lastNode.next = l;
        }

  return newHead;
        
        
        
    }
}

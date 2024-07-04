ListNode cur = head;
        
        while(cur.next != null)
        {
            ListNode nextN = cur.next;
            
            ListNode nextNext = nextN.next;
            nextN.next = null;

            if(nextN.val!=0)
                cur.val += nextN.val;
            else if(nextN.val==0 && nextNext!=null)
                cur = nextN;

            cur.next = nextNext;
        }
        
        return head;

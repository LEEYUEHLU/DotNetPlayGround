using System;
public class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int val=0, ListNode next=null) {
        this.val = val;
        this.next = next;
    }

    public int GetNumber()
    {
        ListNode a = this;
        int layerNumber = 0;
        int number = 0;
        while(a != null){
            number += (a.val) * (int)Math.Pow(10,layerNumber);;
            a = a.next;
            layerNumber ++;
        }
        return number;
    }
}

public class AddTwoNumbersAsLinkList {
    public ListNode AddTwoNumbers(ListNode a, ListNode b) {
        ListNode la = a;
        ListNode lb = b;
        ListNode r,ri = new ListNode();
        r = ri;
        int carry = 0;

        while (la != null || lb != null || ri != null)
        {
            var b_value = (lb == null ? 0 : lb.val); 
            var a_value = (la == null ? 0 : la.val); 
            int total = b_value + a_value + carry;
            ri.val = total % 10;
            carry  = total / 10;
            if(la != null && la.next != null){
                ri.next = new ListNode();
            }
            if(lb != null && lb.next != null){
                ri.next = new ListNode();
            }
            if(carry == 1){
                ri.next = new ListNode();
            }
            Console.WriteLine($"la val:{a_value} p2 val:{b_value} r1:{ri.val} carry:{carry}");
            lb = lb == null ? null : lb.next; 
            la = la == null ? null : la.next;
            ri = ri.next ; 
        }
        return r;
    }
}
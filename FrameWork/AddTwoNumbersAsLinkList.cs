using System;
public class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int val=0, ListNode next=null) {
        this.val = val;
        this.next = next;
    }
}

public class AddTwoNumbersAsLinkList {
    public ListNode AddTwoNumbers(ListNode a, ListNode b) {
        Console.WriteLine("Add two numbers");
        ListNode la = a;
        ListNode lb = b;
        ListNode r1 = new ListNode();
        int carry = 0;

        while (la != null || lb != null)
        {
            var b_value = (lb == null ? 0 : lb.val); 
            var a_value = (la == null ? 0 : la.val); 
            int total = b_value + a_value + carry;
            r1.val = total % 10;
            carry  = total / 10;
            r1.next = new ListNode();
            Console.WriteLine($"la val:{a_value} p2 val:{b_value} r1:{r1.val}");
            lb = lb == null ? null : lb.next; 
            la = la == null ? null : la.next;
            r1 = r1 == null ? null : r1.next;
        }
        return la;
    }
}
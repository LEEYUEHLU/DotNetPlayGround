using System;
using Solution; 

namespace PlayGroundConsole
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        
        public void Test1(){
            ListNode a1 = new ListNode();
            ListNode a2 = new ListNode();
            ListNode a3 = new ListNode();
            ListNode b1 = new ListNode();
            ListNode b2 = new ListNode();
            ListNode b3 = new ListNode();
            a1.val = 2;
            a2.val = 4;
            a3.val = 3;
            b1.val = 5;
            b2.val = 6;
            b3.val = 4;
            a1.next = a2;
            a2.next = a3;
            b1.next = b2;
            b2.next = b3;
            AddTwoNumbersAsLinkList addTwoNumbersAsLinkList = new AddTwoNumbersAsLinkList();
            addTwoNumbersAsLinkList.AddTwoNumbers(a1,b1);
        }
    }
}

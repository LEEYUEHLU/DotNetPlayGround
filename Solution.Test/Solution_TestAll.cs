using System;
using System.Diagnostics;
using NUnit.Framework;
using Solution;

namespace Solution
{
    [TestFixture]
    public class LeetCodeSolutions
    {
        private TwoSumSolution twoSumSolution;
        private AddTwoNumbersAsLinkList addTwoNumbersAsLinkList;

        [SetUp]
        public void SetUp()
        {
            Trace.Listeners.Add(new TextWriterTraceListener(Console.Out));
            Trace.WriteLine("Entering Main");

            twoSumSolution = new TwoSumSolution();
            addTwoNumbersAsLinkList = new AddTwoNumbersAsLinkList();
        }

        [Test]
        public void ReturnTwoSumIndex_GivenArray2n7n11n15AndTarget_Return0n1(){
            Assert.AreEqual(new int[]{0,1}, twoSumSolution.TwoSum(new int[]{2,7,11,15},9));
        }

        [Test]
        public void AddTwoLinkList_342n465_Return807(){
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
            var a = addTwoNumbersAsLinkList.AddTwoNumbers(a1,b1);
            Assert.AreEqual(807,a.GetNumber());
        }

        [Test]
        public void AddTwoLinkList_342n65_Return704(){
            ListNode a1 = new ListNode();
            ListNode a2 = new ListNode();
            ListNode a3 = new ListNode();
            ListNode b1 = new ListNode();
            ListNode b2 = new ListNode();
            a1.val = 2;
            a2.val = 4;
            a3.val = 3;
            b1.val = 5;
            b2.val = 6;
            a1.next = a2;
            a2.next = a3;
            b1.next = b2;
            AddTwoNumbersAsLinkList addTwoNumbersAsLinkList = new AddTwoNumbersAsLinkList();
            var mergedList = addTwoNumbersAsLinkList.AddTwoNumbers(a1,b1);
            Assert.AreEqual(407,mergedList.GetNumber());
        }

        [Test]
        public void AddTwoLinkList_45n55_Return100(){
            ListNode a1 = new ListNode();
            ListNode a2 = new ListNode();
            ListNode b1 = new ListNode();
            ListNode b2 = new ListNode();
            a1.val = 5;
            a2.val = 4;
            b1.val = 5;
            b2.val = 5;
            a1.next = a2;
            b1.next = b2;
            var mergedList = addTwoNumbersAsLinkList.AddTwoNumbers(a1,b1);
            Assert.AreEqual(100,mergedList.GetNumber());
        } 
    }
}

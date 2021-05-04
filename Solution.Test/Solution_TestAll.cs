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
        public void AddTwoNumbers(){
            ListNode l1 = new ListNode(1);
            ListNode l2 = new ListNode(2);
            addTwoNumbersAsLinkList.AddTwoNumbers(l1,l2);
            TestContext.Progress.WriteLine("s");
        }
        public void AddTwoLinkList_243n56_Return704(){
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
            addTwoNumbersAsLinkList.AddTwoNumbers(a1,b1);
            //Assert.AreEqual(new int[]{7,0,4},)
        }
    }
}

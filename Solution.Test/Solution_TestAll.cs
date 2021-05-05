using System;
using System.Diagnostics;
using NUnit.Framework;
using Solution;

namespace Solution
{
    [TestFixture]
    public class LeetCodeSolutions
    {
        [SetUp]
        public void SetUp()
        {
        }

        [Test]
        public void ReturnTwoSumIndex_GivenArray2n7n11n15AndTarget_Return0n1(){
            TwoSumSolution twoSumSolution = new TwoSumSolution();
            Assert.AreEqual(new int[]{0,1}, twoSumSolution.TwoSum(new int[]{2,7,11,15},9));
        }
    }
}

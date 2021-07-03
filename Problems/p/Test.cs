using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Problems.p
{
    [TestClass]
    public class Test
    {
        private Solution solution = new();

        // Test Cases
        private readonly List<(int[] nums, int target, int[] expect)> cases = new()
        {
            (new int[] { 2, 7, 11, 15 }, 9, new int[] { 0, 1 }),
            (new int[] { 3, 2, 4 }, 6, new int[] { 1, 2 }),
            (new int[] { 3, 3 }, 6, new int[] { 0, 1 }),
        };



        [TestMethod]
        public void TestMethod1()
        {
            int i = 0;
            foreach (var testCase in cases)
            {
                var act = solution.Solution1(testCase.nums, testCase.target);
                //Assert.AreEqual<int[]>(testCase.expect, act);
                CollectionAssert.AreEquivalent(testCase.expect, act, string.Format("\rcase: {0}", i));
                i++;
            }
        }
    }
}

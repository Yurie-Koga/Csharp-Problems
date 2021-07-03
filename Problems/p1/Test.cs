using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Problems.p1
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
        public void TestTwoSum1()
        {
            int i = 0;
            foreach (var testCase in cases)
            {
                var act = solution.TwoSum1(testCase.nums, testCase.target);
                CollectionAssert.AreEquivalent(testCase.expect, act, string.Format("\rcase: {0}", i));
                i++;
            }
        }


        [TestMethod]
        public void TestTwoSum2()
        {
            int i = 0;
            foreach (var testCase in cases)
            {
                var act = solution.TwoSum2(testCase.nums, testCase.target);
                CollectionAssert.AreEquivalent(testCase.expect, act, string.Format("\rcase: {0}", i));
                i++;
            }
        }
    }
}

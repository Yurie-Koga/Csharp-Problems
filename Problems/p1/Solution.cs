using System;

namespace Problems.p1
{
    public class Solution
    {
        /*
         Runtime: 324 ms, faster than 37.36% of C# online submissions for Two Sum.
         Memory Usage: 32.3 MB, less than 72.83% of C# online submissions for Two Sum.
         */
        public int[] TwoSum2(int[] nums, int target)
        {
            // brute force w/o variables
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                        return new int[] { i, j };
                }
            }
            return Array.Empty<int>();
        }

        /*
         Runtime: 304 ms, faster than 47.89% of C# online submissions for Two Sum.
         Memory Usage: 32.3 MB, less than 72.83% of C# online submissions for Two Sum.
         */
        public int[] TwoSum1(int[] nums, int target)
        {
            // brute force w/ variables
            for (int i = 0; i < nums.Length; i++)
            {
                var first = nums[i];
                for (int j = i + 1; j < nums.Length; j++)
                {
                    var second = nums[j];
                    var addedup = first + second;
                    if (addedup < target)
                        continue;   // next j
                    else if (addedup == target)
                        return new int[] { i, j };
                }
            }
            return Array.Empty<int>();
        }
    }
}

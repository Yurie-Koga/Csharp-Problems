using System;
using System.Collections.Generic;

namespace Problems.p1
{
    public class Solution
    {
        public int[] TwoSum3(int[] nums, int target)
        {
            // dictionary for <possible remains, pair's index>
            // pick up an element from nums
            // if it's in the remains dictionary, match found
            // if not, add remain to the dict as a new possibility
            var remains_dict = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (remains_dict.ContainsKey(nums[i]))
                    return new int[] { remains_dict[nums[i]], i };
                else
                    remains_dict[target - nums[i]] = i;
            }
            return Array.Empty<int>();
        }

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

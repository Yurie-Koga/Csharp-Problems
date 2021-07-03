using System;
using System.Collections.Generic;

namespace Problems.p1
{
    public class Solution
    {
        /*
         * Runtime: 232 ms, faster than 97.35% of C# online submissions for Two Sum.
         * Memory Usage: 32.3 MB, less than 74.03% of C# online submissions for Two Sum.
         */
        public int[] TwoSum5(int[] nums, int target)
        {
            var remains_dict = new Dictionary<int, int>();

            /* TryGetValue */
            for (int i = 0; i < nums.Length; i++)
            {
                if (remains_dict.TryGetValue(nums[i], out int res))
                    return new int[] { res, i };
                else
                    remains_dict[target - nums[i]] = i;
            }

            return Array.Empty<int>();
        }

        /*
         * Runtime: 308 ms, faster than 47.95% of C# online submissions for Two Sum.
         * Memory Usage: 34.3 MB, less than 5.56% of C# online submissions for Two Sum.
         */
        public int[] TwoSum4(int[] nums, int target)
        {
            var remains_dict = new Dictionary<int, int>();

            /* Tyr-Catch */
            for (int i = 0; i < nums.Length; i++)
            {
                try
                {
                    return new int[] { remains_dict[nums[i]], i };
                }
                catch (Exception)
                {
                    remains_dict[target - nums[i]] = i;
                }
            }

            return Array.Empty<int>();
        }

        /*
         * Runtime: 232 ms, faster than 97.35% of C# online submissions for Two Sum.
         * Memory Usage: 32.9 MB, less than 18.73% of C# online submissions for Two Sum.
         */
        public int[] TwoSum3(int[] nums, int target)
        {
            // dictionary for <possible remains, pair's index>
            // pick up an element from nums
            // if it's in the remains dictionary, match found
            // if not, add remain to the dict as a new possibility

            var remains_dict = new Dictionary<int, int>();

            /* Check key existing */
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
         * Runtime: 324 ms, faster than 37.36% of C# online submissions for Two Sum.
         * Memory Usage: 32.3 MB, less than 72.83% of C# online submissions for Two Sum.
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
         * Runtime: 304 ms, faster than 47.89% of C# online submissions for Two Sum.
         * Memory Usage: 32.3 MB, less than 72.83% of C# online submissions for Two Sum.
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

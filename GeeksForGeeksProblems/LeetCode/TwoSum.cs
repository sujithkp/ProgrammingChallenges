using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeeksForGeeksProblems.LeetCode
{
    public class TwoSumSolution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            int startIndex = 0;
            int endIndex = 0;

            int sum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                endIndex = i;
                sum += nums[i];

                if (sum > target)
                {
                    while (sum > target)
                        sum -= nums[startIndex++];
                }

                if (sum == target)
                    return new int[] { startIndex, endIndex };
            }

            return new int[] { -1, -1 };
        }

        public int[] TwoSum2(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length - 1; i++)
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                        return new int[] { i, j };

                }

            return new int[] { -1, -1 };
        }

        public int[] TwoSum3(int[] nums, int target)
        {
            var dict = new Dictionary<int, IList<int>>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (!dict.ContainsKey(nums[i]))
                    dict.Add(nums[i], new List<int>());

                dict[nums[i]].Add(i);
            }

            for (int i = 0; i < nums.Length; i++)
            {
                var diff = target - nums[i];

                if (dict.ContainsKey(diff))
                {
                    var pair = dict[diff];

                    var index = pair.Where(x => x != i).FirstOrDefault();

                    if (index != null)
                        return new int[] { i, index };
                }
            }

            return new int[] { -1, -1 };
        }
    }
}

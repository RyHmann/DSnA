using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{

    public class TwoSum
    {
        /*
        Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.

        You may assume that each input would have exactly one solution, and you may not use the same element twice.

        You can return the answer in any order. 
        */
        public int[]? Numbers { get; set; }

        public TwoSum(int[]? numbers)
        {
            Numbers = numbers;
        }


        public int[] TwoSumSolution(int[] nums, int target)
        {
            var answer = new int[2];

            var intMap = new Dictionary<int, int>();


            for (int i = 0; i < nums.Length; i++)
            {
                var currentInt = nums[i];
                var targetInt = target - currentInt;
                if (intMap.ContainsKey(targetInt))
                {
                    answer[0] = intMap[targetInt];
                    answer[1] = intMap[targetInt];
                    return answer;
                }
                intMap.Add(currentInt, i);
            }
            return answer;
        }

        public int[] TwoSumNSquared(int[] nums, int target)
        {
            var answer = new int[2];

            for (int i = 0; i < nums.Length; i++)
            {
                int currentNum = nums[i];
                int complementNum = target - currentNum;

                for (int j = i + 1; j < nums.Length; j++)
                {
                    int testNum = nums[j];
                    if (testNum == complementNum)
                    {
                        answer[0] = i;
                        answer[1] = j;
                        return answer;
                    }
                }
            }
            return answer;
        }
    }
}

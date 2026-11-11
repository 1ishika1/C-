using System;
using System.Collections.Generic;
public class Solution
{
    public int[] TwoSumBetter(int[] nums, int target)
    {
        Dictionary<int, int> map = new Dictionary<int, int>();
        for(int i = 0; i < nums.Length; i++)
        {
           int complement = target - nums[i];
           if(map.ContainsKey(complement))
           {
             return new int[]{map[complement], i};
           }
           map[nums[i]] = i;
         }
     return new int[]{};
    }
    public static void Main()
    {
        Solution solution = new Solution();
        int[] nums = {2, 6, 5, 8, 11};
        int target = 14;
        int[] result = solution.TwoSumBetter(nums, target);
        Console.WriteLine("[" + result[0] + "," + result[1] + "]");
    }
}